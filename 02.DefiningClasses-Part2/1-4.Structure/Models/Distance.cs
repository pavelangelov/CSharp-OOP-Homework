namespace _1_4.Structure.Models
{
    using System;

    public static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double distance;

            double distanceX = (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X);
            double distanceY = (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y);
            double distanceZ = (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z);

            distance = Math.Sqrt(distanceX + distanceY + distanceZ);

            return distance;
        }
    }
}
