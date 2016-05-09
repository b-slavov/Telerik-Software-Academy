using System;
using System.Linq;

class MaximalSum
{
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

        int maximalSum = int.MinValue;
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
                    maximalSum = currentSum;
                }
            }
        }

        Console.WriteLine(maximalSum);
    }
}
