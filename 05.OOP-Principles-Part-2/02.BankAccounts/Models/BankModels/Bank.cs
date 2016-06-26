namespace BankAccounts.Models.BankModels
{
    using System.Collections.Generic;
    using Contracts;

    public class Bank
    {
        private List<IAccount> accounts;
        private List<ICustomer> customers;

        public Bank(string name)
        {
            this.Name = name;
            this.Accounts = new List<IAccount>();
            this.Customers = new List<ICustomer>();
        }

        public string Name { get; set; }

        public List<IAccount> Accounts
        {
            get
            {
                return new List<IAccount>(this.accounts);
            }
            set
            {
                this.accounts = value;
            }
        }

        public List<ICustomer> Customers
        {
            get
            {
                return new List<ICustomer>(this.customers);
            }
            private set
            {
                this.customers = value;
            }
        }
    }
}
