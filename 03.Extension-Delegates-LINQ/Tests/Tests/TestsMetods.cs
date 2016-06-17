namespace ProgramTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using ExtensionMethods;
    using Students.Models;

    public class TestsMethods
    {
        public static void StringBuilder()
        {
            var sb = new StringBuilder("123456789");
            var newSb = sb.SubString(2, 5);
            sb = sb.SubString(1);
            Console.WriteLine("SubString: " + sb);
            Console.WriteLine("SubString with length: " + newSb);
        }

        public static void IEnumerableInt(IEnumerable<int> enumeration)
        {
            Console.WriteLine("*****Tested with integers");
            var sum = enumeration.Sum();
            var product = enumeration.Product();
            var min = enumeration.Min();
            var max = enumeration.Max();
            var average = enumeration.Average();

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Average: " + average);
        }

        public static void IenumerableDouble(IEnumerable<double> enumeration)
        {
            Console.WriteLine("*****Tested with real numbers");
            var sum = enumeration.Sum();
            var product = enumeration.Product();
            var min = enumeration.Min();
            var max = enumeration.Max();
            var average = enumeration.Average();

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Average: " + average);
        }

        public static void IntroduceStudents(Student[] students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student.Introduce());
            }
        }
        
        public static string CollectionToString<T>(ICollection<T> collection)
        {
            return "[ " + string.Join(", ", collection) + " ]";
        }
        
        public static string LongestString(string someText)
        {
            var words =
                from word in someText.Split(new[] { ' ', ',', '.', '!', ':', ';', '?' }, StringSplitOptions.RemoveEmptyEntries)
                orderby word.Length
                select word;

            return words.LastOrDefault();

        }
        
        public static int[] FindDivisibleBy7And3(int[] numbers)
        {
            Func<int, bool> func = delegate (int x)
            { return x % 7 == 0 && x % 3 == 0; };
            var selected = numbers.Where(x => func(x))
                                  .ToArray();

            return selected;
        }
    }
}
