namespace StudentClass
{
    using Models;
    using Models.AddressEnumerations;
    using Models.UniversityEnumerations;
    using Tests;

    class Startup
    {
        static void Main()
        {
            var students = CreateStArr();

            var student = new Student
                    ("Pavel", "St.", "Angelov",
                    new Address(CityType.Sofia, NeighbourhoodType.Lulin),
                    UniversityType.SofiaUniversity,
                    FacultyType.FacultyDevelopment,
                    SpecialtyType.WebDeveloper,
                    CourseType.CSharp_OOP,
                    99887766,
                    "some@mail.com");

            Test.TestEquals(students, student);

            Test.TestOperator(students, student);

            Test.TestGetHashCode(students);

            Test.TestClone(student);

        }

        public static Student[] CreateStArr()
        {
            var studentsArr = new Student[]
            {
                new Student("Pavel", "St.", "Angelov", new Address(CityType.Sofia, NeighbourhoodType.Lulin), UniversityType.SofiaUniversity, FacultyType.FacultyDevelopment, SpecialtyType.WebDeveloper, CourseType.CSharp_OOP, 99887766, "some@mail.com"),
                new Student("Petyr", "Hr.", "Petrov", new Address(CityType.Sofia, NeighbourhoodType.Mladost), UniversityType.NewBulgarianUniversity, FacultyType.FacultyDevelopment, SpecialtyType.WebDeveloper, CourseType.JS_OOP),
                new Student("Angel", "St.", "Angelov", new Address(CityType.Plovdiv, NeighbourhoodType.Center), UniversityType.SofiaUniversity, FacultyType.FacultyDevelopment, SpecialtyType.FrontEndDeveloper, CourseType.JS_Fundamentals),
                new Student("Ralica", "Al.", "Kostova", new Address(CityType.Varna, NeighbourhoodType.Center), UniversityType.SofiaUniversity, FacultyType.FacultyOfLaw, SpecialtyType.Lawyer, CourseType.CrimeLaw, 88776655, "another@mail.com"),
                new Student("Petia", "St.", "Kirilova", new Address(CityType.Burgas, NeighbourhoodType.Lazur), UniversityType.NewBulgarianUniversity, FacultyType.FacultyOfMedicine, SpecialtyType.Nurse, CourseType.Nurse),
                new Student("Kristina", "Iv.", "Ivanova", new Address(CityType.Sofia, NeighbourhoodType.Center), UniversityType.SofiaUniversity, FacultyType.FacultyDevelopment, SpecialtyType.WebDeveloper, CourseType.CSharp_OOP)
            };

            return studentsArr;
        }

    }
}
