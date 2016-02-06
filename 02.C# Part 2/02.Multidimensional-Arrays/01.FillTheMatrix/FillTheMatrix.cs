using System;

class FillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BuildFirstMatrix(n);
        BuildSecondMatrix(n);
        BuildThirdMatrix(n);
        BuildFourthMatrix(n);
    }

    static void BuildFirstMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = counter;
                counter++;
            }
        }

        PrintMatrix(matrix);
    }

    static void BuildSecondMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = counter;
                    counter++;
                }
            }
        }

        PrintMatrix(matrix);
    }

    static void BuildThirdMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int beginningRow = n - 1;
        int beginningCol = 0;
        int counter = 0;
        int currentValue = 1;
        while (currentValue <= n * n)
        {
            int currentRow = beginningRow + counter;
            int currentCol = beginningCol + counter;
            matrix[currentRow, currentCol] = currentValue;
            counter++;
            currentValue++;

            if (beginningRow > 0)
            {
                if (currentRow == n - 1)
                {
                    beginningRow--;
                    counter = 0;
                }
            }
            else
            {
                if (currentCol == n - 1)
                {
                    beginningCol++;
                    counter = 0;
                }
            }
        }

        PrintMatrix(matrix);
    }

    static void BuildFourthMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        bool[,] usedPlaces = new bool[n, n];
        int currentValue = 1;
        int currentRow = 0;
        int currentCol = 0;
        string direction = "down";
        while (currentValue <= n * n)
        {
            matrix[currentRow, currentCol] = currentValue;
            usedPlaces[currentRow, currentCol] = true;
            currentValue++;
            if (direction == "down")
            {
                if (currentRow == n - 1 || usedPlaces[currentRow + 1, currentCol] == true)
                {
                    direction = "right";
                    currentCol++;
                }
                else
                {
                    currentRow++;
                }
            }
            else if (direction == "right")
            {
                if (currentCol == n - 1 || usedPlaces[currentRow, currentCol + 1] == true)
                {
                    direction = "up";
                    currentRow--;
                }
                else
                {
                    currentCol++;
                }

            }
            else if (direction == "up")
            {
                if (currentRow == 0 || usedPlaces[currentRow - 1, currentCol] == true)
                {
                    direction = "left";
                    currentCol--;
                }
                else
                {
                    currentRow--;
                }
            }
            else if (direction == "left")
            {
                if (currentRow == n - 1 || usedPlaces[currentRow, currentCol - 1] == true)
                {
                    direction = "down";
                    currentRow++;
                }
                else
                {
                    currentCol--;
                }
            }
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        Console.WriteLine();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,-2} ", matrix[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}