namespace _03.AnimalHierarchy.Models
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, uint age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public override string AnimalSound()
        {
            return $"I`m {this.Name}. Quack quack!";
        }
    }
}
