namespace _01.SchoolClasses.Models
{
    using System;
    using Interfaces;

    public class Student :  IPerson, IComments
    {
        private string name;
        private int classNumber;
        
        public Student(string name, Class studentClass)
        {
            this.Name = name;
            this.StudentClass = studentClass;
            this.classNumber = StudentClass.ReturnStudentID();
            this.StudentClass.Students.Add(this);
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 2 || value.Length > 20 || char.IsLower(value[0]))
                {
                    throw new ArgumentException("Invalid student name!");
                }

                this.name = value;
            }
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                this.classNumber = value;
            }
        }

        public string Comment { get; set; }

        public Class StudentClass { get; set; }

        public override int GetHashCode()
        {
            return this.name.GetHashCode() * 17 + this.classNumber;
        }

        public override string ToString()
        {
            return $" {this.Name} from {this.StudentClass.Identifier} class, Class Number: {this.ClassNumber}";
        }
    }
}
