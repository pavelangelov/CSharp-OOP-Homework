namespace ProgramTests
{
    using System.Linq;
    using Students.Models;

    public class TestStudentsWithLambda
    {
        public static Student[] LambdaSortedByName(Student[] students)
        {
            var sorted = students.OrderByDescending(x => x.FirstName)
                                  .ThenByDescending(x => x.LastName)
                                  .ToArray();

            return sorted;
        }

        public static Student[] ExtractByNumberOfMarks(Student[] students, int numberOfMarks)
        {
            var selected = students.Where(st => st.Marks.Count == 2)
                                    .ToArray();

            return selected;
        }

        public static string ExtractStudentsByDepartName(Student[] students, string departName)
        {
            var selected = students.Where(st => st.Group.DepartmentName == departName)
                                    .Select(x => x.FullName)
                                    .ToArray();
            return $"{departName}\r\n{string.Join(", ", selected)}";
        }
    }
}
