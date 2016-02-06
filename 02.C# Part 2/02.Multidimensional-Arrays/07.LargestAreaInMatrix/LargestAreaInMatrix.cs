using System;

class LargestAreaInMatrix
{
    //Depth-first search algorithm
    public static bool[,] isVisited = new bool[5, 6];
    public static int maxCount = int.MinValue;

    public static int DFS(byte[,] matrix, int currentRow, int currentCol, byte lastElement)
    {
        int result = 0;

        if (!(-1 < currentRow && currentRow < matrix.GetLength(0)))
        {
            return result;
        }

        if (!(-1 < currentCol && currentCol < matrix.GetLength(1)))
        {
            return result;
        }

        if (isVisited[currentRow, currentCol])
        {
            return result;
        }

        if (matrix[currentRow, currentCol] != lastElement)
        {
            return result;
        }

        isVisited[currentRow, currentCol] = true;

        result = 1;

        result += DFS(matrix, currentRow, currentCol + 1, matrix[currentRow, currentCol]);
        result += DFS(matrix, currentRow, currentCol - 1, matrix[currentRow, currentCol]);
        result += DFS(matrix, currentRow + 1, currentCol, matrix[currentRow, currentCol]);
        result += DFS(matrix, currentRow - 1, currentCol, matrix[currentRow, currentCol]);

        return result;
    }

    static void Main()
    {
        byte[,] matrix =
        {
           {1, 3, 2, 2, 2, 4},
           {3, 3, 3, 2, 4, 4},
           {4, 3, 1, 2, 3, 3},
           {4, 3, 1, 3, 3, 1},
           {4, 3, 3, 3, 1, 1}
        };

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                if (!isVisited[rows, cols])
                {
                    int current = DFS(matrix, rows, cols, matrix[rows, cols]);
                    maxCount = Math.Max(current, maxCount);
                }
            }
        }

        Console.WriteLine("Number of neighbour elements: {0}", maxCount);
    }
}