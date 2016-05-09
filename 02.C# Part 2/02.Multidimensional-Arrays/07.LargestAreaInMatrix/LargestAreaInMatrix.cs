using System;
using System.Linq;

class LargestAreaInMatrix
{
    static int DFS(int[,] matrix, int row, int col, bool[,] visited)
    {
        int result = 1;
        visited[row, col] = true;
        if (row - 1 >= 0 && matrix[row - 1, col] == matrix[row, col] && !visited[row - 1, col])
        {
            result += DFS(matrix, row - 1, col, visited);
        }

        if (row + 1 < matrix.GetLength(0) && matrix[row + 1, col] == matrix[row, col] && !visited[row + 1, col])
        {
            result += DFS(matrix, row + 1, col, visited);
        }

        if (col - 1 >= 0 && matrix[row, col - 1] == matrix[row, col] && !visited[row, col - 1])
        {
            result += DFS(matrix, row, col - 1, visited);
        }

        if (col + 1 < matrix.GetLength(1) && matrix[row, col + 1] == matrix[row, col] && !visited[row, col + 1])
        {
            result += DFS(matrix, row, col + 1, visited);
        }

        return result;
    }

    static void Main()
    {
        int[] rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = rowsAndCols[0];
        int cols = rowsAndCols[1];
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            int[] inputRow = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }

        bool[,] visited = new bool[rows, cols];
        int maxCount = 0;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (!visited[row, col])
                {
                    int count = DFS(matrix, row, col, visited);
                    if (maxCount < count)
                    {
                        maxCount = count;
                    }
                }

            }
        }

        Console.WriteLine(maxCount);
    }
}
