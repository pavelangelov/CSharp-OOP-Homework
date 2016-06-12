namespace _1_4.Structure
{
    using System;
    using Models;

    class TestStructure
    {
        static void Main()
        {
            Point3D point = new Point3D(0, 2, 3);

            Console.WriteLine(Distance.CalculateDistance(point, Point3D.Origin));

            Path paths = new Path();
            paths.Add(Point3D.Origin);
            paths.Add(point);
            paths.Add(new Point3D(1, 3, 5));
            paths.Add(new Point3D(2, 4, 5));
            paths.Add(new Point3D(3, 5, 6));
            paths.Add(new Point3D(4, 6, 7));
            paths.Add(new Point3D(5, 7, 8));

            Console.WriteLine(paths.ShowPoints());

            string path = "../../Paths/paths.txt";
            PathStorage.SavePaths(paths.Points, path);
            
            var anotherPaths = PathStorage.LoadPaths(path);
            Console.WriteLine("Loaded Paths:");
            foreach (var p in anotherPaths)
            {
                Console.WriteLine(p);
            }

        }
    }
}
