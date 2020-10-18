using System;
using System.Collections.Generic;

namespace Stacc.Models
{
    public class Ticker
    {
        public  String name {get; set;}
        public  tickers[] tickers { get; set; }

        public String toString()
        {
            return name + " " + tickers[0].converted_last.usd;
        }
    }

    public class tickers
    {
        public converted_last converted_last { get; set; }
        public DateTime timestamp { get; set; }

    }
    public class converted_last
    {
        public double usd { get; set; }
    }
}
