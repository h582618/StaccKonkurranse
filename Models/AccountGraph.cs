using System;
namespace Stacc.Models
{
    public class AccountGraph
    {
        public AccountGraph()
        {

        }
        public AccountGraph(DateTime timestamp, double value)
        {
            this.timestamp = timestamp;
            this.value = value;
        }

        public DateTime timestamp;
        public double value { get; set; }
    }

}
