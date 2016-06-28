namespace StudentClass.Tests
{
    using System;
    using System.Collections.Generic;

    using Models;
    using Models.AddressEnumerations;
    using Models.UniversityEnumerations;

    public static class Test
    {
        public static void TestEquals(IEnumerable<Student> students, Student student)
        {
            Console.WriteLine("\n-------------------------------Testting Student.Equals()-------------------------------\n");
            foreach (var st in students)
            {
                string isEqual = student.Equals(st) ? "equal to" : "not equal to";
                Console.WriteLine("{0} is {1} {2}", st.FullName, isEqual, student.FullName);
            }
        }

        public static void TestOperator(IEnumerable<Student> students, Student student)
        {
            Console.WriteLine("\n-------------------------------Testting operator != -------------------------------\n");
            foreach (var st in students)
            {
                Console.WriteLine($"{student.FullName} != {st.FullName}? => {student != st}");
            }
        }

        public static void TestGetHashCode(IEnumerable<Student> students)
        {
            Console.WriteLine("\n-------------------------------Testting Student.GetHashCode()-------------------------------\n");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName}`s HashCode is: {student.GetHashCode()}");
            }
        }

        public static void TestClone(Student student)
        {
            Console.WriteLine("\n-------------------------------Testting Student.Clone()-------------------------------");
            Console.WriteLine("--The method should deeply copy all object's fields into a new object of type Student--\n");

            var secondStudent = student.Clone() as Student;

            secondStudent.FirstName = "PaveL";
            secondStudent.MiddleName = "ST.";
            secondStudent.LastName = "Angeloff";
            secondStudent.PermanentAddress = new Address(CityType.Burgas, NeighbourhoodType.Lazur);
            secondStudent.Specialty = SpecialtyType.Lawyer;
            secondStudent.Faculty = FacultyType.FacultyOfLaw;
            secondStudent.University = UniversityType.NewBulgarianUniversity;
            secondStudent.Course = CourseType.CivilLaw;
            secondStudent.SSN = 99887711;
            secondStudent.Email = "someOther@mail.com";

            foreach (var prop in student.GetType().GetProperties())
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"First student property \"{prop.Name}\" = {prop.GetValue(student)}");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Second student property \"{prop.Name}\" = {prop.GetValue(secondStudent)}");
                Console.WriteLine();
            }
        }
    }
}
