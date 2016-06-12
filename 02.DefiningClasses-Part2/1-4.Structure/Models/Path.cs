namespace _1_4.Structure.Models
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void Add(Point3D point)
        {
            this.points.Add(point);
        }

        public string ShowPoints()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < this.points.Count; i++)
            {
                result.AppendLine(points[i].ToString());
            }

            return result.ToString();
        }

        public List<Point3D> Points
        {
            get
            {
                return this.points;
            }
            set
            {
                this.points = value;
            }
        }
    }
}
