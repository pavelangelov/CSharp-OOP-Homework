namespace Validations
{
    using System;
    using Constants;

    public static class ShapesParamsValidation
    {
        public static double CheckWidth(double widthValue)
        {
            if (widthValue < ConstantValues.Width_Min_Value || widthValue > ConstantValues.Width_Max_Value)
            {
                throw new ArgumentOutOfRangeException("Invalid width value!");
            }

            return widthValue;
        }

        public static double CheckHeight(double heightValue)
        {
            if (heightValue < ConstantValues.Height_Min_Value || heightValue > ConstantValues.Height_Max_Value)
            {
                throw new ArgumentOutOfRangeException("Invalid height value!");
            }

            return heightValue;
        }

        public static double CheckSquareSide(double squareSide)
        {
            if (squareSide < ConstantValues.SquareSide_Min_Value || squareSide > ConstantValues.SquareSide_Max_Value)
            {
                throw new ArgumentOutOfRangeException("Invalid square side value!");
            }

            return squareSide;
        }
    }
}
