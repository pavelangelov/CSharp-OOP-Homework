namespace _01.SchoolClasses.Models
{
    using Interfaces;

    public class Discipline : IComments
    {
        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public string Name { get; private set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return $"{this.Name} => Lectures: {this.NumberOfLectures}, Exercises: {this.NumberOfExercises}";
        }
    }
}
