namespace BankAccounts.Models.CustomerModels
{
    using System;
    using Contracts;

    public class IndividualCustomer : ICustomer
    {
        public IndividualCustomer(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
    }
}
