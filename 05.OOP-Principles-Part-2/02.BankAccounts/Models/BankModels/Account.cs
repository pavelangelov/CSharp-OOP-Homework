namespace BankAccounts.Models.BankModels
{
    using System;

    using Contracts;
    using Validations.Constants;

    public abstract class Account : IAccount
    {
        public Account(ICustomer customer, decimal startCapital, decimal interestRate, decimal numberOfMonths)
        {
            this.Customer = customer;
            this.Balance = startCapital;
            this.InterestRate = interestRate;
            this.NumberOfMonths = numberOfMonths;
        }

        public decimal Balance { get; protected set; }

        public ICustomer Customer { get; protected set; }

        public decimal InterestRate { get; set; }

        public decimal NumberOfMonths { get; set; }

        public abstract decimal CalculateAmount();

        public virtual void MakeDeposit(decimal moneyToDeposit)
        {
            if (moneyToDeposit < ConstantValues.Deposit_Min_Value)
            {
                throw new ArgumentException($"The deposit value must be greater or equal to {ConstantValues.Deposit_Min_Value}");
            }

            this.Balance += moneyToDeposit;
        }
    }
}
