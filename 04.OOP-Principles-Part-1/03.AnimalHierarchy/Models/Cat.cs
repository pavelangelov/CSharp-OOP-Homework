namespace _03.AnimalHierarchy.Models
{
    using System;

    public abstract class Cat : Animal
    {
        public abstract string Roar { get; }

        public abstract string Purr();
    }
}
