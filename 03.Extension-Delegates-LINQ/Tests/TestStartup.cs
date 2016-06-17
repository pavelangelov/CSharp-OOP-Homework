namespace Tests
{
    using System;
    using System.Collections.Generic;

    using ProgramTests;
    using Students.Models;
    using System.Linq;

    class TestStartup
    {
        static void Main()
        {
            string buffer = new string('-', 40);
            
            Console.WriteLine($"{buffer}Problem1.StringBuilder.SubString Extencion{buffer}\r\n");
            TestsMethods.StringBuilder();
            Console.WriteLine();
            
            Console.WriteLine($"{buffer}Problem2.IEnumerable Extensions{buffer}\r\n");
            TestsMethods.IEnumerableInt(new List<int>() { 2, 1, 5, 3, 4 });
            TestsMethods.IenumerableDouble(new List<double>() { 2.1, 1.5, 5.4, 3.2, 4.8 });
            Console.WriteLine();
            
            var students = new Student[]
            {
                new Student("Pavel", "Angelov", 29, "02/9252525", "mail@abv.bg", new List<double>() { 4,6,6,5,6}, new Group(2, "Mathematics")),
                new Student("Anton", "Dimitrov", 19, "032/9443322", "mail@mail.bg", new List<double>() { 4,6},  new Group(3, "Art")),
                new Student("Daniel", "Georgiev", 32, "0719/927", "mail@gmail.com", new List<double>() { 4,4,6}, new Group(1, "Biology")),
                new Student("Krasimir", "Angelov", 26, "02/9254422", "mail@yahoo.com", new List<double>() { 4,2,4,2,6},  new Group(2, "Mathematics")),
                new Student("Aleksander", "Ivanov", 33, "0883212121", "mail@gbg.bg", new List<double>() { 5,6}, new Group(1, "Biology")),
                new Student("Kiril", "Petkov", 22, "0897123123", "mail4e@mail.bg", new List<double>() { 4,3,4,4,6}, new Group(3, "Art")),
                new Student("Rangel", "Dimitrov", 40, "0888223344", "mailche@abv.bg", new List<double>() { 4,3,4,4,6},  new Group(2, "Mathematics")),
                new Student("Ivan", "Petrov", 36, "0878765432", "poshta@mail.bg", new List<double>() { 4,3,4,4,6}, new Group(3, "Art")),
                new Student("Gospodin", "Kostadinov", 31, "0899112233", "poshta@mail.bg", new List<double>() { 4,3,4,4,6},  new Group(2, "Mathematics"))

            };

            Console.WriteLine($"{buffer}Problem 3. First before last{buffer}\r\n");
            var selectedByName = TestStudentsWithLINQ.FirstNameBeforeLastName(students);
            TestsMethods.IntroduceStudents(selectedByName);
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 4. Age range{buffer}\r\n");
            var selectedByAge = TestStudentsWithLINQ.SelectByAge(students, 18, 24);
            TestsMethods.IntroduceStudents(selectedByAge);
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 5. Order students{buffer}\r\n");
            var sortedByName = TestStudentsWithLambda.LambdaSortedByName(students);
            TestsMethods.IntroduceStudents(sortedByName);
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 6. Divisible by 7 and 3{buffer}\r\n");
            var numbers = new int[] { 2, 3, 4, 54, 21, 63, 35, 70, 42, 25 };
            var divisible = TestsMethods.FindDivisibleBy7And3(numbers);
            Console.WriteLine(TestsMethods.CollectionToString(divisible) + "\r\n");

            Console.WriteLine($"{buffer}Problem 9. Student groups{buffer}\r\n");
            var selectedByGroup = TestStudentsWithLINQ.GetStudentsByGroup(students, 2);
            TestsMethods.IntroduceStudents(selectedByGroup);
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 11. Extract students by email{buffer}\r\n");
            var selectedByEmail = TestStudentsWithLINQ.GetStudentsByEmail(students, "abv.bg");
            TestsMethods.IntroduceStudents(selectedByEmail);
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 12. Extract students by phone{buffer}\r\n");
            var selectedByPhone = TestStudentsWithLINQ.GetStudensByZipCode(students, "02/");
            TestsMethods.IntroduceStudents(selectedByPhone);
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 13. Extract students by marks{buffer}\r\n");
            var selectByMarks =
                from student in students
                where student.Marks.Contains(6)
                select new { FullName = student.FullName, Marks = student.Marks };
            foreach (var st in selectByMarks)
            {
                Console.Write($"Name: {st.FullName}, ");
                Console.Write($"Marks: {TestsMethods.CollectionToString(st.Marks)}");
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 14. Extract students by marks{buffer}\r\n");
            var studentsWithTwoMarks = TestStudentsWithLambda.ExtractByNumberOfMarks(students, 2);
            TestsMethods.IntroduceStudents(studentsWithTwoMarks);
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 16.* Groups{buffer}\r\n");
            var studentsByDeptName = TestStudentsWithLambda.ExtractStudentsByDepartName(students, "Mathematics");
            Console.WriteLine(studentsByDeptName);

            Console.WriteLine($"{buffer}Problem 17. Longest string{buffer}\r\n");
            var text = "By using delegates, develop an universal static method.";
            Console.WriteLine(TestsMethods.LongestString(text + "\r\n"));

            Console.WriteLine($"{buffer}Problem 18. Grouped by GroupNumber{buffer}\r\n");
            TestStudentsWithLINQ.GroupByGroupNumber(students);
            Console.WriteLine();

            Console.WriteLine($"{buffer}Problem 19. Grouped by GroupName extensions{buffer}\r\n");
            TestStudentsWithLINQ.GroupByGroupName(students);
            Console.WriteLine();
        }
        
    }
}
