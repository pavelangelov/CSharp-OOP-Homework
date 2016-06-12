namespace _8_10.Matrix
{
    using System;
    using _8_10.Matrix.Models;
    using _11.VersionAttribute.Models;

    [VersionAttributes(1, 1)]
    class MatrixTest
    {
        static void Main()
        {

            //Sum of two matrix
            Matrix<double> firstMatrix = new Matrix<double>(4, 5);
            Matrix<double> secondMatrix = new Matrix<double>(4, 5);
            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    firstMatrix[row, col] = 1.5 + col;
                    secondMatrix[row, col] = 1.5 * col;
                }
            }

            Matrix<double> thirdMatrix = firstMatrix + secondMatrix;

            Console.WriteLine("First matrix: \r\n" + firstMatrix);
            Console.WriteLine("Second matrix: \r\n" + secondMatrix);
            Console.WriteLine("Sum: \r\n" + thirdMatrix);

            Console.WriteLine("First matrix: " + (firstMatrix ? "No zeroes in the matrix." : "Has zeroes."));
            Console.WriteLine("Second matrix: " + (secondMatrix ? "No zeroes in the matrix." : "Has zeroes."));
            Console.WriteLine();
            // Product of two matrix
            Matrix<int> numbers = new Matrix<int>(2, 3);
            Matrix<int> secondNumbers = new Matrix<int>(3, 2);
            int indexValue = 1;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    numbers[row, col] = indexValue;
                    indexValue++;
                }
            }

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    secondNumbers[row, col] = indexValue;
                    indexValue++;
                }
            }

            Matrix<int> thirdNumbers = numbers * secondNumbers;

            Console.WriteLine("First matrix: \r\n" + numbers);
            Console.WriteLine("Second matrix: \r\n" + secondNumbers);
            Console.WriteLine("Product : \r\n" + thirdNumbers);
            
            Console.WriteLine("First matrix: " + (numbers ? "No zeroes in the matrix." : "Has zeroes."));
            Console.WriteLine("Second matrix: " + (secondNumbers ? "No zeroes in the matrix." : "Has zeroes."));


            Type type = typeof(MatrixTest);
            object[] attr = type.GetCustomAttributes(false);
            Console.WriteLine();
            Console.WriteLine(attr[0]);
        }
    }
}
