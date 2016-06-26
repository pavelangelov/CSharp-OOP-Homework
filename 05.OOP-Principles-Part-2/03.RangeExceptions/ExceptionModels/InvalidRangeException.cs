namespace RangeExceptions.ExceptionModels
{
    using System;
    using Validations.Constants;

    public class InvalidRangeException<T> : Exception where T : struct, IComparable, IConvertible
    {
        private const string Integer_Exception_Message = "The number {0} isn`t in the range [{1} - {2}]";
        private const string DateTime_Exception_Message = "The date {0} isn`t in the range [{1} - {2}]";

        private static string min_Date = $"{ConstantValues.Month_Min_Value}/{ConstantValues.Day_Min_Value}/{ConstantValues.Year_Min_Value}";
        private static string max_Date = $"{ConstantValues.Month_Max_Value}/{ConstantValues.Day_Max_Value}/{ConstantValues.Year_Max_Value}";

        public InvalidRangeException(int number) 
            : base(string.Format(Integer_Exception_Message, number, ConstantValues.Number_Min_Value, ConstantValues.Number_Max_Value))
        {
        }

        public InvalidRangeException(DateTime date)
            : base(string.Format(DateTime_Exception_Message, date.ToShortDateString(), min_Date, max_Date))
        {

        }
    }
}
