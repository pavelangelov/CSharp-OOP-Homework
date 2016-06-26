namespace BankAccounts.Models.BankModels
{
    using CustomerModels;
    using Contracts;

    public class Loan : Account
    {
        private const int IndividualCustomers_Free_Months = 3;
        private const int CompanyCustomers_Free_Months = 2;

        public Loan(ICustomer customer, decimal startCapital, decimal interestRate, decimal numberOfMonths)
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
                return (this.NumberOfMonths - CompanyCustomers_Free_Months) * this.InterestRate;
            }
        }
    }
}
