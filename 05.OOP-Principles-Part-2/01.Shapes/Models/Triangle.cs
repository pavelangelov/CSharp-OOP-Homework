namespace Shapes.Models
{
    using Contracts;
    using Validations;

    public class Triangle : Shape, ICalculateble
    {
        public Triangle(double width, double height)
        {
            this.Width = ShapesParamsValidation.CheckWidth(width);
            this.Height = ShapesParamsValidation.CheckHeight(height);
        }

        public override double CalculateSurface()
        {
            return this.Height * (this.Width / 2); 
        }
    }
}
