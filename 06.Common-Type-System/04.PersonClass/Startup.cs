namespace PersonClass
{
    using System;
    using Models;

    class Startup
    {
        static void Main()
        {
            var people = new Person[]
            {
                new Person("Petyr"),
                new Person("Dimityr", 22),
                new Person("Nadya"),
                new Person("Petya", 26),
                new Person("Krasimir"),
                new Person("Anita", 16),
                new Person("Mira"),
                new Person("Stefan", 44),

            };

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
