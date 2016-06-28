namespace PersonClass.Models
{
    using System.Text;

    public class Person
    {
        private string name;
        private int? age;

        public Person(string name)
        {
            this.Name = name;
        }

        public Person(string name, int age)
            : this(name)
        {
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public int? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {this.Name}");
            if (this.Age == null)
            {
                sb.AppendLine("Age: unknown");
            }
            else
            {
                sb.AppendLine($"Age: {this.Age}");
            }

            return sb.ToString();
        }
    }
}
