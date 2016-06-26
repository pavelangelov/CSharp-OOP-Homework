namespace Shapes.Models
{
    using Contracts;
    using Validations;

    public class Square : Shape, ICalculateble
    {
        public Square(double side)
        {
            this.Width = ShapesParamsValidation.CheckSquareSide(side);
            this.Height = ShapesParamsValidation.CheckSquareSide(side);
        }
        
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
