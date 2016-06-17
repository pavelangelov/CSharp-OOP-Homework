namespace Students.Models
{
    using System.Collections.Generic;

    

    public class Student
    {
        private static int studentId = 1;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FullName = this.FirstName + " " + this.LastName;
            this.Age = age;
            this.Id = studentId;
            studentId++;
            this.Marks = new List<double>();
        }

        public Student(string firstName, string lastName, int age, string phoneNumber, string email, List<double> marks, Group group)
            : this(firstName, lastName, age)
        {
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.Group = group;
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string FullName { get; private set; }

        public int Age { get; private set; }

        public int Id { get; private set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<double> Marks { get; set; }

        public Group Group { get; set; }

        public string Introduce()
        {
            return $"{this.FullName}, {this.Age} years old, FN: {this.Id}, Phone Number: {this.PhoneNumber}, Email: {this.Email}, Marks: {this.GetMarks()}, Group Number: {this.Group}";
        }

        private string GetMarks()
        {
            return "[ " + string.Join(", ", this.Marks) + " ]";
        }

    }
}
