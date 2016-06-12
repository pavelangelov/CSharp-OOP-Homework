namespace _1_4.Structure.Models
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePaths(List<Point3D> points, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);
            using (writer)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    writer.WriteLine(points[i]);
                }
                
            }
        }

        public static List<Point3D> LoadPaths(string filePath)
        {
            List<Point3D> points = new List<Point3D>();
            StreamReader reader = new StreamReader(filePath);
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    int[] coordinates = line.Split(new[] { '{', ',', '}' }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
                    int x = coordinates[0];
                    int y = coordinates[1];
                    int z = coordinates[2];
                    points.Add(new Point3D(x, y, z));

                    line = reader.ReadLine();
                }

            }

            return points;
        }
    }
}
