namespace _5_7.GenericClass
{
    using Models;
    using System;

    class GenericListTest
    {
        static void Main()
        {
            GenericList<int> listOfNumbers = new GenericList<int>(4);
            listOfNumbers.Add(5);
            listOfNumbers.Add(6);
            listOfNumbers.Add(7);
            listOfNumbers.Add(8);
            listOfNumbers.Remove(2);
            listOfNumbers.Insert(2, 7);
            listOfNumbers.Add(7);
            listOfNumbers.Add(1);
            listOfNumbers.Add(7);

            Console.WriteLine(listOfNumbers);
            Console.WriteLine(listOfNumbers.IsContain(7));
            Console.WriteLine("Min= " + listOfNumbers.Min());
            Console.WriteLine("Max= " + listOfNumbers.Max());

            listOfNumbers.Clear();
            Console.WriteLine(listOfNumbers);

            GenericList<string> listOfStrings = new GenericList<string>(8);
            listOfStrings.Add("a");
            listOfStrings.Add("b");
            listOfStrings.Add("c");
            listOfStrings.Add("Z");
            listOfStrings.Add("d");
            listOfStrings.Add("D");
            listOfStrings.Insert(1, "A");
            Console.WriteLine(listOfStrings);
            Console.WriteLine(listOfStrings.IsContain("A"));
            Console.WriteLine("Min= " + listOfStrings.Min());
            Console.WriteLine("Max= " + listOfStrings.Max());


        }
    }
}
