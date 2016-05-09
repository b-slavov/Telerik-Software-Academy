using System;
using System.Linq;

class SequenceNMatrix
{
    static int LongestSequence(int[,] matrix)
    {
        int currentCount = 1;
        int bestCount = 0;

        // check rows
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                }
            }

            currentCount = 1;
        }

        // check columns
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                }
            }

            currentCount = 1;
        }

        // check left-to-right diagonal
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            for (int row = 0, column = col; row < matrix.GetLength(0) - 1 && column < matrix.GetLength(1) - 1; row++, column++)
            {
                if ((matrix[row, column] == matrix[row + 1, column + 1]))
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                }
            }

            currentCount = 1;
        }


        // check right-to-left diagonal
        for (int col = matrix.GetLength(1) - 1; col > 0; col--)
        {
            for (int row = 0, column = col; row < matrix.GetLength(0) - 1 && column > 0; row++, column--)
            {
                if ((matrix[row, column] == matrix[row + 1, column - 1]))
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > bestCount)
                {
                    bestCount = currentCount;
                }
            }
        }

        return bestCount;
    }

    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = input[0];
        int cols = input[1];
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] inputRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }

        Console.WriteLine(LongestSequence(matrix));
    }
}
