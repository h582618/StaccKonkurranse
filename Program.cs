using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Stacc.Models;

namespace Stacc
{
    public class Program
    {
        public static String coinApi = "https://api.coingecko.com/api/v3/coins/list";

        public static List<Accounts> accounts { get; set; } = RunAsync().GetAwaiter().GetResult();
        public static List<Coins> coins { get; set; } = CoinsRunAsync().GetAwaiter().GetResult();
        public static Ticker ticker { get; set; } = TickersRunAsync("omisego").GetAwaiter().GetResult();
        public static List<Ticker> tickers { get; set; } = new List<Ticker>();
        public static List<AccountView> accountView { get; set; } = new List<AccountView>();

        //Metode som finner riktig id til riktig konto.
        public static String getCorrectId(List<Coins> coins1, String name)
        {
            foreach(Coins coin in coins1)
            {
                if (coin.symbol.ToUpper().Equals(name.ToUpper()))
                {
                   
                    return coin.id;
                }
            }
            return null;
        }

        public static void Main(string[] args)
        {

             //For å ta vekk mynter som ikke er i kontoer
            List<Coins> finalCoins = coins.AsEnumerable()
            .Where(x => accounts.Any(y => y.balance.currency.ToUpper().Equals(x.symbol.ToUpper()))).ToList();


          
            foreach (var account in accounts)
            {
                
            
                List<tickers> tickers = TickersRunAsync(getCorrectId(finalCoins, account.balance.currency)).GetAwaiter().GetResult().tickers.ToList();
                accountView.Add(new AccountView(account.name, account.balance.currency, tickers[0].converted_last.usd * Convert.ToDouble(account.balance.amount), account.balance.amount,tickers));
    
            }


            foreach(AccountView acc in accountView)
            {
                Console.WriteLine(acc.name + " " + acc.currency + " " + acc.value);
            }
          
            
            CreateHostBuilder(args).Build().Run();
        }

           

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static async Task<List<Accounts>> RunAsync()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;


            

            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }
            defaultRequestHeaders.Authorization =
              new AuthenticationHeaderValue("bearer", "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCIsImtpZCI6Ik0wTXhNVEEzTVVFeU5rRkZSREZGTnpSRE1VUXdPVVU0TXpBNFF6QkdRVVF6UkVSRE1VSTNSUSJ9.eyJpc3MiOiJodHRwczovL3N0YWNjeC5ldS5hdXRoMC5jb20vIiwic3ViIjoiejQ0RGdzWVFKREtyNTRCcmZvU0x3c2pLWWRtUDRLdWtAY2xpZW50cyIsImF1ZCI6Imh0dHBzOi8vc3RhY2MuZmludGVjaCIsImlhdCI6MTYwMTIwNTAwNywiZXhwIjoxNjAzNzk3MDA3LCJhenAiOiJ6NDREZ3NZUUpES3I1NEJyZm9TTHdzaktZZG1QNEt1ayIsImd0eSI6ImNsaWVudC1jcmVkZW50aWFscyJ9.fBvgUGcc1zS3eStbdGo19mLC6KqOdMeBdo_xuZEBz9jCzllRfrgqIhPbys5Se2XreGxu5_6oKWlXbqDOvnbuvjTJKnhoO9Aom1meUjqbQgaROeN0hbmPxVDKF-JDtOdZbAWtZv1ds9bWF0zqo9Z7ogicZ0eUi8FnEA2h2I6peVQPL9cJJwSfhjXPW73Ws4e6c0vynnhXLc5BcQgst0iaMZd4n3tdruzP_bgEY5GqbKvJxHjL2KNHh933VZSZdx_7mf4imsgsed2AL1QkIkqj5lvf_niyzrEmOLs_K_rSOZqRzO0c1u9wxrCK7qlryzpv8nz3C3zXfNdnMQHOejOFpQ");

            HttpResponseMessage response = await httpClient.GetAsync("https://fintech-webinar-2020-api.vercel.app/api/accounts");


            
            if (response.IsSuccessStatusCode)
            {
                string result1 = await response.Content.ReadAsStringAsync();
                List<Accounts> currenciesAPI = JsonConvert.DeserializeObject<List<Accounts>>(result1);
                return currenciesAPI;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Failed to call the Web Api: {response.StatusCode}");
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Content: {content}");
            }
            Console.ResetColor();
        
            return null;
        }


        public static async Task<List<Coins>> CoinsRunAsync()
        {
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;




            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }
          

            HttpResponseMessage response = await httpClient.GetAsync(coinApi);


  
            if (response.IsSuccessStatusCode)
            {
                string result1 = await response.Content.ReadAsStringAsync();
                List<Coins> currenciesAPI = JsonConvert.DeserializeObject<List<Coins>>(result1);
                return currenciesAPI;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Failed to call the Web Api: {response.StatusCode}");
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Content: {content}");
            }
            Console.ResetColor();

            return null;
        }
        public static async Task<Ticker> TickersRunAsync(String id)
        {
            String tickersApi = "https://api.coingecko.com/api/v3/coins/" + id + "/tickers";
            var httpClient = new HttpClient();
            var defaultRequestHeaders = httpClient.DefaultRequestHeaders;




            if (defaultRequestHeaders.Accept == null ||
               !defaultRequestHeaders.Accept.Any(m => m.MediaType == "application/json"))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new
                  MediaTypeWithQualityHeaderValue("application/json"));
            }


            HttpResponseMessage response = await httpClient.GetAsync(tickersApi);


        
            if (response.IsSuccessStatusCode)
            {
                string result1 = await response.Content.ReadAsStringAsync();
                Ticker currenciesAPI = JsonConvert.DeserializeObject<Ticker>(result1);
                return currenciesAPI;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Failed to call the Web Api: {response.StatusCode}");
                string content = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Content: {content}");
            }
            Console.ResetColor();

            return null;
        }
    }
}
