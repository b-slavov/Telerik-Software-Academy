using System;
using System.Linq;

class LoverOf3
{
    static int[,] FillTheMatrix(int rows, int cols)
    {
        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = 3 * (rows - i - 1 + j);
            }
        }

        return matrix;
    }

    static void Main()
    {
        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = matrixSize[0];
        int cols = matrixSize[1];

        int[,] matrix = FillTheMatrix(rows, cols);

        int row = rows - 1;
        int col = 0;
        int result = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string direction = input[0];
            int moves = int.Parse(input[1]);

            switch (direction)
            {
                case "UR": case "RU":
                    for (int j = 0; j < moves - 1; j++)
                    {
                        if (row == 0 || col == cols - 1)
                        {
                            break;
                        }

                        row--;
                        col++;
                        result += matrix[row, col];
                        matrix[row, col] = 0;
                    }
                    break;

                case "UL": case "LU":
                    for (int j = 0; j < moves - 1; j++)
                    {
                        if (row == 0 || col == 0)
                        {
                            break;
                        }

                        row--;
                        col--;
                        result += matrix[row, col];
                        matrix[row, col] = 0;
                    }
                    break;

                case "DR": case "RD":
                    for (int j = 0; j < moves - 1; j++)
                    {
                        if (row == rows - 1 || col == cols - 1)
                        {
                            break;
                        }

                        row++;
                        col++;
                        result += matrix[row, col];
                        matrix[row, col] = 0;
                    }
                    break;

                case "DL": case "LD":
                    for (int j = 0; j < moves - 1; j++)
                    {
                        if (row == rows - 1 || col == 0)
                        {
                            break;
                        }

                        row++;
                        col--;
                        result += matrix[row, col];
                        matrix[row, col] = 0;
                    }
                    break;
            }
        }

        Console.WriteLine(result);
    }
}
