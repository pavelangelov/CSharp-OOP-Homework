namespace _02.StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Models;

    class Startup
    {
        static void Main()
        {
            var separator = new string('-', 60);
            var students = InitListOfStudents()
                            .OrderBy(x => x.Grade)
                            .ToList();

            var workers = InitListOfWorkers()
                            .OrderByDescending(x => x.MoneyPerHour())
                            .ToList();

            var humans = InitHumanList(students, workers)
                                  .OrderBy(x => x.FirstName + x.LastName)
                                  .Select(x => x.FirstName + " " + x.LastName)
                                  .ToList();

            Console.WriteLine("Students List:\r\n");
            Console.WriteLine(string.Join("\r\n", students));
            Console.WriteLine(separator);

            Console.WriteLine("Workers List:\r\n");
            Console.WriteLine(string.Join("\r\n", workers));
            Console.WriteLine(separator);

            Console.WriteLine("Humans List:\r\n");
            Console.WriteLine(string.Join("\r\n", humans));
            Console.WriteLine(separator);
        }

        public static List<Student> InitListOfStudents()
        {
            List<Student> st = new List<Student>()
            {
                new Student("Pavel", "Angelov", 5.9),
                new Student("Kiril", "Petrov", 3.6),
                new Student("Krasimir", "Angelov", 5.8),
                new Student("Viktoriya", "Krasimirova", 5.3),
                new Student("Nataliya", "Gerova", 5.5),
                new Student("Maya", "Petrova", 4.5),
                new Student("Ivan", "Ivanov", 3.5),
                new Student("Gergana", "Hristova", 5.3),
                new Student("Petya", "Deleva", 4.1),
                new Student("Angel", "Angelov", 5.2)
            };

            return st;
        }

        public static List<Worker> InitListOfWorkers()
        {
            List<Worker> wk = new List<Worker>()
            {
                new Worker("Pavel", "Angeloff", 230, 8),
                new Worker("Krasimir", "Angeloff", 200, 8),
                new Worker("Zdravko", "Bankov", 195, 8),
                new Worker("Snejana", "Beiska", 120, 4),
                new Worker("Aleksandar", "Ivanov", 180, 8),
                new Worker("Ivan", "Bonev", 300, 10),
                new Worker("Elena", "Dimitrova", 140, 6),
                new Worker("Simona", "Angelova", 200, 5.5),
                new Worker("Kiril", "Petroff", 200, 8),
                new Worker("Stanislava", "Koleva", 130, 4)
            };

            return wk;
        }

        public static List<Human> InitHumanList(List<Student> studentsList, List<Worker> workersList)
        {
            List<Human> humanList = new List<Human>();
            foreach (var student in studentsList)
            {
                humanList.Add(student);
            }

            foreach (var worker in workersList)
            {
                humanList.Add(worker);
            }

            return humanList;
        }
    }
}
