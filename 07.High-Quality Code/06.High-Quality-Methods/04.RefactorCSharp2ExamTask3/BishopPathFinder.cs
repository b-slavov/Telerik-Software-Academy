namespace CSharp2ExamTask3
{
    using System;
    using System.Linq;

    class BishopPathFinder
    {
        static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] chessboard = new int[rows, cols];
            int fieldStartIndex = 0;
            for (int row = rows - 1; row >= 0; row--)
            {
                for (int col = 0; col < cols; col++)
                {
                    chessboard[row, col] = (fieldStartIndex + col) * 3;
                }
                fieldStartIndex += 1;
            }

            int directionsAndMovesCount = int.Parse(Console.ReadLine());
            int bishopCounter = 0;
            int currentRow = rows - 1;
            int currentCol = 0;

            for (int i = 0; i < directionsAndMovesCount; i++)
            {
                string[] directionsAndMoves = Console.ReadLine().Split(' ').ToArray();
                string direction = directionsAndMoves[0];
                int moves = int.Parse(directionsAndMoves[1]);
                if (direction == "UR" || direction == "RU")
                {
                    for (int j = 1; j < moves; j++)
                    {
                        if (currentRow > 0 && currentCol < cols - 1)
                        {
                            currentRow -= 1;
                            currentCol += 1;
                            bishopCounter += chessboard[currentRow, currentCol];
                            chessboard[currentRow, currentCol] = 0;
                        }
                    }
                }
                if (direction == "UL" || direction == "LU")
                {
                    for (int j = 1; j < moves; j++)
                    {
                        if (currentRow > 0 && currentCol > 0)
                        {
                            currentRow -= 1;
                            currentCol -= 1;
                            bishopCounter += chessboard[currentRow, currentCol];
                            chessboard[currentRow, currentCol] = 0;
                        }
                    }
                }
                if (direction == "DR" || direction == "RD")
                {
                    for (int j = 1; j < moves; j++)
                    {
                        if (currentRow < rows - 1 && currentCol < cols - 1)
                        {
                            currentRow += 1;
                            currentCol += 1;
                            bishopCounter += chessboard[currentRow, currentCol];
                            chessboard[currentRow, currentCol] = 0;
                        }
                    }
                }
                if (direction == "DL" || direction == "LD")
                {
                    for (int j = 1; j < moves; j++)
                    {
                        if (currentRow < rows - 1 && currentCol > 0)
                        {
                            currentRow += 1;
                            currentCol -= 1;
                            bishopCounter += chessboard[currentRow, currentCol];
                            chessboard[currentRow, currentCol] = 0;
                        }
                    }
                }
            }

            Console.WriteLine(bishopCounter);
        }
    }
}