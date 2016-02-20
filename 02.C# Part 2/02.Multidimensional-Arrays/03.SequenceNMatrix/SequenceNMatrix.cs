using System;
using System.Linq;

class SequenceNMatrix
{
    static string LongestSequence(string[,] matrix)
    {
        int currentCount = 1;
        int bestCount = 0;
        string itemMostCounted = string.Empty;

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
                    itemMostCounted = matrix[row, col];
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
                    itemMostCounted = matrix[row, col];
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
                    itemMostCounted = matrix[row, column];
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
                    itemMostCounted = matrix[row, column];
                }
            }
        }

        return string.Join(", ", Enumerable.Repeat(itemMostCounted, bestCount).ToArray());
    }

    static void Main()
    {
        string[,] firstExample =
        {
            { "ha", "fifi", "ho", "hi" },
            { "fo", "ha", "hi", "xx" },
            { "xxx", "ho", "ha", "xx" }
        };

        string[,] secondExample =
        {
            { "s", "qq", "s" },
            { "pp", "pp", "s" },
            { "pp", "qq", "s" }
        };

        string[,] thirdExample =
        {
            { "abc", "def", "wat", "ghi" },
            { "jkl", "wat", "mno", "prs" },
            { "wat", "tuv", "wxy", "zzz" }
        };

        Console.WriteLine(LongestSequence(firstExample));
        Console.WriteLine(LongestSequence(secondExample));
        Console.WriteLine(LongestSequence(thirdExample));
    }
}