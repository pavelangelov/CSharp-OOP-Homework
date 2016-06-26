namespace BankAccounts.Models.BankModels
{
    using System;
    using CustomerModels;
    using Contracts;

    public class Mortgage : Account
    {
        private const int IndividualCustomers_Free_Months = 6;

        public Mortgage(ICustomer customer, decimal startCapital, decimal interestRate, decimal numberOfMonths)
            : base(customer, startCapital, interestRate, numberOfMonths)
        {
        }

        public override decimal CalculateAmount()
        {
            if (this.Customer is IndividualCustomer)
            {
                return (this.NumberOfMonths - IndividualCustomers_Free_Months) * this.InterestRate;
            }
            else
            {
                // Companies have half of their interest rate for the first year

                if (this.NumberOfMonths <= 12)
                {
                    return this.NumberOfMonths * (this.InterestRate / 2);
                }
                else
                {
                    return (12 * (this.InterestRate / 2) + (this.NumberOfMonths - 12 * this.InterestRate));
                }
            }
        }
    }
}
