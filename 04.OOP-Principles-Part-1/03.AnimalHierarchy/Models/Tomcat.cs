namespace _03.AnimalHierarchy.Models
{
    using System;

    public class Tomcat : Cat
    {
        private const string roar = "Myauu Mmmyauu";

        public Tomcat(string name, uint age)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = Gender.Male;
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
            return "Mrrrrhrr!";
        }
        
    }
}
