namespace _03.AnimalHierarchy.Models
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, uint age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = Gender;
        }

        public override string AnimalSound()
        {
            return $"I`m {this.Name}. Bau Bau!";
        }
    }
}
