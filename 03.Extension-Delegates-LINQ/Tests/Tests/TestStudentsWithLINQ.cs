namespace ProgramTests
{
    using System;
    using System.Linq;

    using Students.Models;

    public class TestStudentsWithLINQ
    {

        public static Student[] FirstNameBeforeLastName(Student[] studentsArr)
        {
            var result =
                from student in studentsArr
                where string.Compare(student.FirstName, student.LastName) < 0
                select student;

            return result.ToArray();
        }

        public static Student[] SelectByAge(Student[] studentsArr, int minAge, int maxAge)
        {
            var selected =
                from student in studentsArr
                where student.Age >= minAge && student.Age <= maxAge
                select student;

            return selected.ToArray();
        }

        public static Student[] GetStudentsByGroup(Student[] students, int group)
        {
            var selected =
                from student in students
                where student.Group.GroupNumber == 2
                select student;

            return selected.ToArray();
        }

        public static Student[] GetStudentsByEmail(Student[] students, string email)
        {
            var selected =
                from student in students
                where student.Email.Contains(email)
                select student;

            return selected.ToArray();
        }

        public static Student[] GetStudensByZipCode(Student[] students, string zipCode)
        {
            var selected =
                from student in students
                where student.PhoneNumber.Contains(zipCode)
                select student;

            return selected.ToArray();
        }

        public static void GroupByGroupNumber(Student[] students)
        {
            var groups =
                from student in students
                group student by student.Group.GroupNumber;

            foreach (var group in groups)
            {
                Console.WriteLine($"Group: {group.Key}");
                foreach (var student in group)
                {
                    Console.Write(student.FullName + " | ");
                }
                Console.WriteLine();
            }

        }

        public static void GroupByGroupName(Student[] students)
        {
            var groups =
                from student in students
                group student by student.Group.DepartmentName;

            foreach (var group in groups)
            {
                Console.WriteLine(group.Key);
                foreach (var student in group)
                {
                    Console.Write(student.FullName + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
