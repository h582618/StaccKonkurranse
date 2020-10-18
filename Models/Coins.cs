using System;
namespace Stacc.Models
{
    public class Coins
    {
        public String id { get; set; }
        public String symbol { get; set; }
        public String name { get; set; }

        public Coins(string id, string symbol, string name)
        {
            this.id = id;
            this.symbol = symbol;
            this.name = name;
        }
    }
}
