namespace _01.SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Class : School, IComments
    {
        private string identifier;
        private int usedId;

        public Class(string className)
        {
            this.identifier = className;
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
            this.usedId = 0;
        }

        public Class(string className, HashSet<Student> students, HashSet<Teacher> teachers)
            : this(className)
        {
            this.Students = students;
            this.Teachers = teachers;
        }

        public string Comment { get; set; }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }
            private set
            {
                if (base.Classes.Contains(value))
                {
                    throw new ArgumentException("This class already exist!");
                }

                this.identifier = value;
                base.Classes.Add(this.identifier);
            }
        }

        public HashSet<Student> Students { get; set; }

        public HashSet<Teacher> Teachers { get; private set; }
        
        internal int ReturnStudentID()
        {
            this.usedId += 1;
            return this.usedId;
        }

        public override string ToString()
        {
            string separator = "\r\n" + new string('-', 100);
            return $"{this.Identifier} class{separator}\r\nTeachers:\r\n{string.Join("\r\n", this.Teachers)}{separator}\r\nStudents:\r\n{string.Join("\r\n", this.Students)}{separator}";
        }
    }
}
