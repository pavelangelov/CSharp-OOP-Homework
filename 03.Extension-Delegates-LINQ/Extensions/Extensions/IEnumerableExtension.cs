namespace ExtensionMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtension
    {
        public static T Sum<T>(this IEnumerable<T> enumeration) where T : struct, IComparable, IFormattable, IConvertible
        {
            T sum = default(T);
            foreach (var item in enumeration)
            {
                sum += (dynamic)item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> enumeration) where T : struct, IComparable, IFormattable, IConvertible
        {
            T product = (dynamic)1;
            foreach (var item in enumeration)
            {
                product *= (dynamic)item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> enumeration) where T : struct, IComparable, IFormattable, IConvertible
        {
            T min = enumeration.FirstOrDefault();
            foreach (var item in enumeration)
            {
                if (min > (dynamic)item)
                {
                    min = item;
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> enumeration) where T: IComparable, IFormattable, IConvertible
        {
            T max = enumeration.FirstOrDefault();
            foreach (var item in enumeration)
            {
                if (max < (dynamic)item)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double Average<T>(this IEnumerable<T> enumeration) where T : struct, IConvertible, IComparable, IFormattable
        {
            T sum = enumeration.Sum();
            double average = (dynamic)sum / enumeration.Count();

            return average;
        }
    }
}
