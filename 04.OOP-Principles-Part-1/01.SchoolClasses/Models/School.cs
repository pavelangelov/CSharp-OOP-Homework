namespace _01.SchoolClasses.Models
{
    using System.Collections.Generic;

    public class School
    {
        private HashSet<string> classes;

        public School()
        {
            this.classes = new HashSet<string>();
        }
        
        public HashSet<string> Classes
        {
            get
            {
                HashSet<string> toReturn = new HashSet<string>(this.classes);
                return toReturn;
            }
            private set
            {
                this.classes = value;
            }
        }
    }
}
