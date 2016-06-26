namespace BankAccounts.Models.CustomerModels
{
    using System;
    using Contracts;

    public class CompanyCustomer : ICustomer
    {
        public CompanyCustomer(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
