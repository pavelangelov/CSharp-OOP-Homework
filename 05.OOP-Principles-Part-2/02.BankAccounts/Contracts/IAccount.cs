namespace BankAccounts.Contracts
{
    using Models.CustomerModels;

    public interface IAccount
    {
        ICustomer Customer { get; }

        decimal Balance { get; }
        
        decimal NumberOfMonths { get; set; }

        decimal InterestRate { get; set; }

        decimal CalculateAmount();

        void MakeDeposit(decimal moneyToDeposit);
    }
}
