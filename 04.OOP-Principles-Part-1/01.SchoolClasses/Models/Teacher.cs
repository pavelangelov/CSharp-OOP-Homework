namespace _01.SchoolClasses.Models
{
    using System;
    using System.Collections.Generic;

    using Interfaces;

    public class Teacher : IPerson, IComments
    {
        private string name;

        public Teacher(string name)
        {
            this.Name = name;
            this.Disciplines = new HashSet<Discipline>();
            
        }

        public Teacher(string name, HashSet<Discipline> disciplines)
            : this(name)
        {
            this.Disciplines = disciplines;
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

        public string Comment { get; set; }

        public HashSet<Discipline> Disciplines { get; private set; }

        public override string ToString()
        {
            return $"{this.Name}\r\n Teaches: {string.Join(", ", this.Disciplines)}";
        }
    }
}
