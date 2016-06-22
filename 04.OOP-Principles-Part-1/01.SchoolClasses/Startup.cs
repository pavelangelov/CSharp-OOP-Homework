namespace _01.SchoolClasses
{
    using System;
    using Models;

    class Startup
    {
        static void Main()
        {
            School school = new School();

            Class firstA = new Class("1A");
            Class secondB = new Class("2B");
            Class thirdC = new Class("3C");

            school.Classes.Add(firstA.Identifier);
            school.Classes.Add(secondB.Identifier);
            school.Classes.Add(thirdC.Identifier);

            Student pavel = new Student("Pavel",firstA);
            Student petyr = new Student("Petyr",secondB);
            Student kiril = new Student("Kiril",thirdC);
            Student vanya = new Student("Vanya",firstA);
            Student natali = new Student("Natali",secondB);
            Student simona = new Student("Simona", thirdC);
            Student krasi = new Student("Krasimir", firstA);
            Student gosho = new Student("Georgi", secondB);
            Student toni = new Student("Anton", thirdC);

            firstA.Students.Add(new Student("Dimityr", firstA));

            Teacher gogo = new Teacher("Georgi");
            gogo.Disciplines.Add(new Discipline("Math", 4, 20));
            gogo.Disciplines.Add(new Discipline("Technology", 6, 24));

            Teacher maya = new Teacher("Maya");
            maya.Disciplines.Add(new Discipline("Biology", 4, 22));
            maya.Disciplines.Add(new Discipline("Sciens", 6, 18));

            Teacher koko = new Teacher("Konstantin");
            koko.Disciplines.Add(new Discipline("Physics", 6, 30));
            koko.Disciplines.Add(new Discipline("Astronomy", 2, 10));

            firstA.Teachers.Add(gogo);
            firstA.Teachers.Add(koko);

            secondB.Teachers.Add(gogo);
            secondB.Teachers.Add(maya);
            secondB.Teachers.Add(koko);

            thirdC.Teachers.Add(maya);
            thirdC.Teachers.Add(koko);

            Console.WriteLine(firstA);
            Console.WriteLine(secondB);
            Console.WriteLine(thirdC);
        }
    }
}
