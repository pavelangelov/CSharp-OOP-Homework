namespace Validations.Constants
{
    public class ConstantValues
    {

        // Shapes Constants
        internal const double Width_Min_Value = 0;
        internal const double Width_Max_Value = double.MaxValue;

        internal const double Height_Min_Value = 0;
        internal const double Height_Max_Value = double.MaxValue;

        internal const double SquareSide_Min_Value = 0;
        internal const double SquareSide_Max_Value = double.MaxValue;


        // Bank Account Constants
        public const decimal DepositAccount_Min_Value_For_Amount = 1000;

        public const decimal Deposit_Min_Value = 5;

        // Range Exception Constants

        public const int Number_Min_Value = 1;
        public const int Number_Max_Value = 100;

        public const int Day_Min_Value = 1;
        public const int Month_Min_Value = 1;
        public const int Year_Min_Value = 1980;

        public const int Day_Max_Value = 31;
        public const int Month_Max_Value = 12;
        public const int Year_Max_Value = 2013;
    }
}
