using System;
using System.Collections.Generic;

namespace Stacc.Models
{
    public class AccountView
    {
        public AccountView(string name, string currency, double value, String amount, List<tickers> tickers)
        {
            this.name = name;
            this.currency = currency;
            this.value = value;
            this.amount = amount;
            this.tickers = tickers;
        }
        public String name { get; set; }
        public String currency { get; set; }
        public String amount { get; set; }
        public double value { get; set; }
        public List<tickers> tickers { get; set; } 
    }
}
