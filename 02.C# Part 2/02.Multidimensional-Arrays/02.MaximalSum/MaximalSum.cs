using System;

class MaximalSum
{
    static void PrintMatrix(int[,] matrix, int wantedValueRow, int wantedValueCol)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                bool currentRowIsWithinTheSquare = row == wantedValueRow || row == wantedValueRow + 1 || row == wantedValueRow + 2;
                bool currentColIsWithinTheSquare = col == wantedValueCol || col == wantedValueCol + 1 || col == wantedValueCol + 2;
                if (currentRowIsWithinTheSquare && currentColIsWithinTheSquare)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write("{0,-2} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }

    static int[,] ReadMatrix()
    {
        Console.Write("Enter rows: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter columns: ");
        int cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the values:");
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0},{1}: ", row, col);
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        return matrix;
    }

    static void Main()
    {
        var matrix = ReadMatrix();

        int maximalSum = 0;
        int wantedValueRow = 0;
        int wantedValueCol = 0;
        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int currentSum = 0;
                for (int i = 0; i < 3; i++)
                {
                    currentSum += matrix[row, col + i];
                    currentSum += matrix[row + 1, col + i];
                    currentSum += matrix[row + 2, col + i];
                }

                if (currentSum > maximalSum)
                {
                    wantedValueCol = col;
                    wantedValueRow = row;
                    maximalSum = currentSum;
                }
            }
        }

        PrintMatrix(matrix, wantedValueRow, wantedValueCol);
        Console.WriteLine("Maximal sum = {0}", maximalSum);
    }
}