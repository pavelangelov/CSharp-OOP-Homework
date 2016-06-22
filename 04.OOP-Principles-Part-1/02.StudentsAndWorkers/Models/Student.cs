using System;

namespace _02.StudentsAndWorkers.Models
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.grade = grade;
        }

        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}, Grade: {this.Grade}";
        }
    }
}
