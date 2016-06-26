namespace BankAccounts.Models.BankModels
{
    using System;
    
    using Contracts;
    using Validations.Constants;

    public class Deposit : Account
    {
        public Deposit(ICustomer customer, decimal startCapital, decimal interestRate, decimal numberOfMonths) 
            : base(customer, startCapital, interestRate, numberOfMonths)
        {
        }

        public override decimal CalculateAmount()
        {
            if (this.Balance < ConstantValues.DepositAccount_Min_Value_For_Amount)
            {
                throw new ArgumentOutOfRangeException("Your balance is not enough for this operation!");
            }

            return this.NumberOfMonths * this.InterestRate;
        }
        
        public decimal Draw(decimal moneyToDraw)
        {
            if (CheckDrawOperation(moneyToDraw))
            {
                throw new ArgumentOutOfRangeException("You don`t have enough money in your account!");
            }

            this.Balance -= moneyToDraw;
            return moneyToDraw;
        }

        private bool CheckDrawOperation(decimal moneyToDraw)
        {
            return moneyToDraw > this.Balance;
        }
        
    }
}
