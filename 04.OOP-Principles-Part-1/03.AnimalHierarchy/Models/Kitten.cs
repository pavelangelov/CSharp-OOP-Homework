using System;

namespace _03.AnimalHierarchy.Models
{
    public class Kitten : Cat
    {
        private const string roar = "Myyaauu Myyyauuu";

        public Kitten(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = Gender.Female;
        }

        public override string Roar
        {
            get
            {
                return roar;
            }
        }

        public override string AnimalSound()
        {
            return $"I`m {this.Name}. {this.Roar}!";
        }

        public override string Purr()
        {
            return "Mrrr Mrrrrrrrrr Mrrrr";
        }
    }
}
