namespace DefiningClassesPartTwo.Matrix
{
    using System;
    using System.Text;

    public class Matrix<T>
        where T : struct, IComparable<T>
    {
        // fields
        private T[,] matrix;

        // constructors
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        // properties
        public int Rows
        {
            get { return this.matrix.GetLength(0); }
        }

        public int Columns
        {
            get { return this.matrix.GetLength(1); }
        }

        // methods
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

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Columns != secondMatrix.Columns)
            {
                throw new ArgumentException("Matrices can't be with different dimensions.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Columns; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Columns != secondMatrix.Columns)
            {
                throw new ArgumentException("Matrices can't be with different dimensions.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Columns);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Columns; col++)
                {
                    result[row, col] = (dynamic)firstMatrix[row, col] - secondMatrix[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Columns != secondMatrix.Rows)
            {
                throw new ArgumentException("Тhe product of two matrices is undefined.");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, secondMatrix.Columns);

            for (int secondCol = 0; secondCol < secondMatrix.Columns; secondCol++)
            {
                dynamic cell = 0;

                for (int firstRow = 0; firstRow < firstMatrix.Rows; firstRow++)
                {
                    for (int firstCol = 0; firstCol < firstMatrix.Columns; firstCol++)
                    {
                        cell += (dynamic)firstMatrix[firstRow, firstCol] * secondMatrix[firstCol, secondCol];
                    }

                    result[firstRow, secondCol] = cell;
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    if ((dynamic)matrix[row, col] != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Columns; col++)
                {
                    if ((dynamic)matrix[row, col] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    result.AppendFormat("{0,3} ", this.matrix[row, col]);
                }

                result.AppendLine();
            }

            return result.ToString().TrimEnd('\n');
        }
    }
}