using System;
namespace Stacc.Models
{
    public class Accounts
    {
        public String id { get; set; }
        public String name { get; set; }
        public Balance balance { get; set; }
        public String created_at { get; set; }
        public String updated_at { get; set; }
        public String resource_path { get; set; }
        public Boolean allow_deposits { get; set; }
        public Boolean allow_withdrawals { get; set; }
        public Boolean active { get; set; }

        public Accounts(string id, string name, Balance balance, string created_at, string updated_at, string resource_path, bool allow_deposits, bool allow_withdrawals, bool active)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.created_at = created_at;
            this.updated_at = updated_at;
            this.resource_path = resource_path;
            this.allow_deposits = allow_deposits;
            this.allow_withdrawals = allow_withdrawals;
            this.active = active;
        }
       
    }

    public class Balance
    {
        public String currency { get; set; }
        public String amount { get; set; }
    }
}
