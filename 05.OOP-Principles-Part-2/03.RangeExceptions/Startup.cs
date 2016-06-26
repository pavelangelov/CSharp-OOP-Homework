namespace RangeExceptions
{
    using System;
    using System.Collections.Generic;
    using ExceptionModels;
    using Validations.Constants;

    class Startup
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n------------------------------ Integer Range Exception ------------------------------\n");
            Console.ForegroundColor = ConsoleColor.Red;

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
            try
            {
                AddNumberToCollection(numbers, 6);
                AddNumberToCollection(numbers, 106);
            }
            catch (InvalidRangeException<int> ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Numbers now contains: {string.Join(", ", numbers)}");


            List<DateTime> dates = new List<DateTime>()
            {
                new DateTime(2000, 12, 25),
                new DateTime(1999, 2, 15),
                new DateTime(2002, 3, 5),
                new DateTime(2013, 5, 4),
            };

            List<DateTime> datesToAdd = new List<DateTime>()
            {
                new DateTime(1979, 12, 31),
                new DateTime(1980, 12, 31),
                new DateTime(1980, 1, 1),
                new DateTime(2014, 1, 1),
                new DateTime(1989, 1, 31),
                new DateTime(1999, 12, 31)
            };

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n------------------------------ Integer Range Exception ------------------------------\n");
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var date in datesToAdd)
            {
                try
                {
                    AddDateToCollection(dates, date);
                }
                catch (InvalidRangeException<DateTime> ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Dates now contains:");
            foreach (var date in dates)
            {
                Console.WriteLine(date.ToShortDateString());
            }

        }

        public static void AddNumberToCollection(ICollection<int> numbersCollection, int number)
        {
            if (number < ConstantValues.Number_Min_Value || number > ConstantValues.Number_Max_Value)
            {
                throw new InvalidRangeException<int>(number);
            }

            numbersCollection.Add(number);
        }

        public static void AddDateToCollection(ICollection<DateTime> datesCollection, DateTime date)
        {
            if (date.Year < ConstantValues.Year_Min_Value || date.Year > ConstantValues.Year_Max_Value)
            {
                throw new InvalidRangeException<DateTime>(date);
            }

            datesCollection.Add(date);
        }
    }
}
