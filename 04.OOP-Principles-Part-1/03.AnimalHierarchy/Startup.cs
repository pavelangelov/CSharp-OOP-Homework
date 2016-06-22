namespace _03.AnimalHierarchy
{
    using System;
    using System.Linq;
    using System.Text;

    using Models;

    class Startup
    {
        static void Main()
        {
            var animals = InitAnimalArray();

            PrintAnimals(animals);
            Console.WriteLine();
            IncreaseAge(animals);
            Console.WriteLine("\r\n---------------------After increasing--------------------");
            PrintAnimals(animals);
            Console.WriteLine("\r\n---------------------Animals sounds--------------------");
            PrintAnimalsSound(animals);

            Console.WriteLine();
            Console.WriteLine(AnimalGroupsAvgAge(animals));

        }

        public static Animal[] InitAnimalArray()
        {
            Animal[] animalsArr = new Animal[]
            {
                new Tomcat("Tom", 3),
                new Kitten("Maca", 2),
                new Dog("Rex", 4, Gender.Male),
                new Dog("Lassy", 10, Gender.Female),
                new Frog("Froggy", 5, Gender.Male),
                new Tomcat("Tomas", 7),
                new Kitten("Suzzy", 6)
            };

            return animalsArr;
        }

        public static void PrintAnimalsSound(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.AnimalSound());
            }
        }

        public static string AnimalGroupsAvgAge(Animal[] animals)
        {
            var sb = new StringBuilder("--------------------Average Group Age--------------------\r\n");
            var currentGroupAge = 0.0;
            var groups =
                from animal in animals
                group animal by animal.GetType();
            

            foreach (var group in groups)
            {
                sb.Append(group.Key.Name + "s");
                foreach (var animal in group)
                {
                    currentGroupAge += animal.Age;
                }
                sb.AppendFormat(" Average Age => {0:F2}\r\n", currentGroupAge / group.Count());
                currentGroupAge = 0.0;
            }

            sb.AppendLine(new string('-', 50));
            return sb.ToString();    
        }

        public static void PrintAnimals(Animal[] animalsArr)
        {
            foreach (var animal in animalsArr)
            {
                Console.WriteLine(animal);
            }
        }

        public static void IncreaseAge(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                animal.IncreaseAge();
            }
        }
    }
}
