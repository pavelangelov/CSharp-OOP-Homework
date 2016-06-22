namespace _03.AnimalHierarchy.Models
{
    using System;
    using Interfaces;

    public abstract class Animal : ISound
    {
        public string Name { get; set; }

        public uint Age { get; set; }

        public Gender Gender { get; protected set; }

        public abstract string AnimalSound();
        
        public void IncreaseAge()
        {
            this.Age++;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} {this.Name}, {this.Age} years old, Sex: {this.Gender}";
        }
    }
}
