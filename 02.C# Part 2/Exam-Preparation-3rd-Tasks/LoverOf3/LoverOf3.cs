using System;
using System.Linq;

class LoverOf3
{
    static void Main()
    {
        int[] matrixSize = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int maxRows = matrixSize[0];
        int maxCols = matrixSize[1];
        int n = int.Parse(Console.ReadLine());

        int rows = 0;
        int cols = 0;
        int result = 0;
        bool[,] visited = new bool[matrixSize[0], matrixSize[1]];
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string direction = input[0];
            int moves = int.Parse(input[1]);

            if (direction == "UR" || direction == "RU" && moves > 1)
            {
                for (int j = 0; j < moves - 1; j++)
                {
                    if (rows == maxRows - 1 || cols == maxCols - 1)
                    {
                        break;
                    }

                    rows++;
                    cols++;
                    if (!visited[maxRows - rows - 1, cols])
                    {
                        result += 3 * (rows + cols);
                        visited[maxRows - rows - 1, cols] = true;
                    }
                }
            }

            if (direction == "UL" || direction == "LU" && moves > 1)
            {
                for (int j = 0; j < moves - 1; j++)
                {
                    if (rows == maxRows - 1 || cols == 0)
                    {
                        break;
                    }

                    rows++;
                    cols--;
                    if (!visited[maxRows - rows - 1, cols])
                    {
                        result += 3 * (rows + cols);
                        visited[maxRows - rows - 1, cols] = true;
                    }
                }
            }

            if (direction == "DR" || direction == "RD" && moves > 1)
            {
                for (int j = 0; j < moves - 1; j++)
                {
                    if (rows == 0 || cols == maxCols - 1)
                    {
                        break;
                    }

                    rows--;
                    cols++;
                    if (!visited[maxRows - rows - 1, cols])
                    {
                        result += 3 * (rows + cols);
                        visited[maxRows - rows - 1, cols] = true;
                    }
                }
            }

            if (direction == "DL" || direction == "LD" && moves > 1)
            {
                for (int j = 0; j < moves - 1; j++)
                {
                    if (rows == 0 || cols == 0)
                    {
                        break;
                    }

                    rows--;
                    cols--;
                    if (!visited[maxRows - rows - 1, cols])
                    {
                        result += 3 * (rows + cols);
                        visited[maxRows - rows - 1, cols] = true;
                    }
                }
            }
        }

        Console.WriteLine(result);
    }
}
