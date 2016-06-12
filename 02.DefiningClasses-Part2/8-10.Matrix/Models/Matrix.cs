namespace _8_10.Matrix.Models
{
    using System;
    using System.Text;
    public class Matrix<T> where T : struct, IConvertible, IEquatable<T>, IComparable<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2) 
        {
            if (m1.rows != m2.rows || m1.cols != m2.cols)
            {
                throw new ArgumentException("You can`t adding matrices with different sizes!");
            }

            Matrix<T> matrixToReturn = new Matrix<T>(m1.rows, m1.cols);
            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.cols; col++)
                {
                    matrixToReturn[row, col] = (dynamic)m1.matrix[row, col] + m2[row, col];
                }
            }

            return matrixToReturn;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.rows != m2.rows || m1.cols != m2.cols)
            {
                throw new ArgumentException("You can`t adding matrices with different sizes!");
            }

            Matrix<T> matrixToReturn = new Matrix<T>(m1.rows, m1.cols);
            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.cols; col++)
                {
                    matrixToReturn[row, col] = (dynamic)m1.matrix[row, col] - m2[row, col];
                }
            }

            return matrixToReturn;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new ArgumentException("The number of columns in first matrix must be equal to the number of rows in second matrix!");
            }
            Matrix<T> result = new Matrix<T>(m1.Rows, m2.Cols);
            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    for (int i = 0; i < m1.Cols; i++)
                    {
                        result[row, col] += (dynamic)m1[row, i] * m2[i, col];
                    }
                }
                
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    sb.AppendFormat("{0, 5}", this.matrix[row, col]);
                }
                sb.Append("\r\n");
            }
            return sb.ToString();
        }
    }
}
