namespace DefiningClasses.Models
{
    using System;

    public class Display
    {
        private double? size;
        private int? colors;

        public Display(double? size = null, int? colors = null)
        {
            this.Size = size;
            this.Colors = colors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            private set
            {
                if (value == null || (value > 3.5 && value < 6))
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException("The size must be greater than 3.5 and less than 6 inchs");
                }
            }
        }

        public int? Colors
        {
            get
            {
                return this.colors;
            }
            private set
            {
                if (value == null || (value > 2 && value <= 16000000))
                {
                    this.colors = value;
                }
                else
                {
                    throw new ArgumentException("Invalid number of colors!");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Size: {0}\" \r\nColors: {1}", this.Size, this.Colors);
        }
    }
}
