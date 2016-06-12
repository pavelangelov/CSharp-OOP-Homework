namespace _1_4.Structure.Models
{
    public struct Point3D
    {
        private static Point3D origin = new Point3D(0, 0, 0);

        private int x;
        private int y;
        private int z;
        

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Point3D Origin
        {
            get
            {
                return origin;
            }
        }

        public int X
        {
            get
            {
                return this.x;
            }
            private set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            private set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            private set
            {
                this.z = value;
            }
        }

        public override string ToString()
        {
            return "{" + $"{this.x}, {this.y}, {this.z}" + "}"; 
        }

    }
}
