using System;

class Warhead
{
    static void Main()
    {
        int[,] board = new int[16, 16];

        for (int i = 0; i < 16; i++)
        {
            string currentLine = Console.ReadLine();
            for (int j = 0; j < 16; j++)
            {
                char currentSymbol = currentLine[j];
                board[i, j] = currentSymbol - '0';
            }
        }

        while (true)
        {
            string currentOperation = Console.ReadLine();

            if (currentOperation == "cut")
            {
                string wire = Console.ReadLine();
                if (wire == "blue")
                {
                    int countBlue = 0;
                    int countRed = 0;

                    for (int row = 1; row < 15; row++)
                    {
                        for (int col = 8; col < 15; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;

                            int aboveRow = row - 1;
                            int belowRow = row + 1;

                            int beforeCol = col - 1;
                            int afterCol = col + 1;

                            bool topLeft = false;
                            bool topMiddle = false;
                            bool topRight = false;
                            bool currentLeft = false;
                            bool currentRight = false;
                            bool bottomLeft = false;
                            bool bottomMiddle = false;
                            bool bottomRight = false;

                            if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, belowRow] == 1)
                            {
                                topLeft = true;
                            }

                            if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                            {
                                topMiddle = true;
                            }

                            if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                            {
                                topRight = true;
                            }

                            if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                            {
                                currentLeft = true;
                            }

                            if (afterCol < 16 && board[currentRow, afterCol] == 1)
                            {
                                currentRight = true;
                            }

                            if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                            {
                                bottomLeft = true;
                            }

                            if (belowRow < 16 && board[belowRow, currentCol] == 1)
                            {
                                bottomMiddle = true;
                            }

                            if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                            {
                                bottomRight = true;
                            }

                            if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                            {
                                for (row = aboveRow; row < +belowRow; row++)
                                {
                                    for (col = beforeCol; col < +afterCol; col++)
                                    {
                                        countBlue++;
                                    }
                                }
                            }
                        }
                    }
                    
                    for (int row = 1; row < 15; row++)
                    {
                        for (int col = 1; col < 8; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;

                            int aboveRow = row - 1;
                            int belowRow = row + 1;

                            int beforeCol = col - 1;
                            int afterCol = col + 1;

                            bool topLeft = false;
                            bool topMiddle = false;
                            bool topRight = false;
                            bool currentLeft = false;
                            bool currentRight = false;
                            bool bottomLeft = false;
                            bool bottomMiddle = false;
                            bool bottomRight = false;

                            if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, belowRow] == 1)
                            {
                                topLeft = true;
                            }

                            if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                            {
                                topMiddle = true;
                            }

                            if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                            {
                                topRight = true;
                            }

                            if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                            {
                                currentLeft = true;
                            }

                            if (afterCol < 16 && board[currentRow, afterCol] == 1)
                            {
                                currentRight = true;
                            }

                            if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                            {
                                bottomLeft = true;
                            }

                            if (belowRow < 16 && board[belowRow, currentCol] == 1)
                            {
                                bottomMiddle = true;
                            }

                            if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                            {
                                bottomRight = true;
                            }

                            if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                            {
                                for (row = aboveRow; row < +belowRow; row++)
                                {
                                    for (col = beforeCol; col < +afterCol; col++)
                                    {
                                        countRed++;
                                    }
                                }
                            }
                        }

                        if (countBlue == 0)
                        {
                            Console.WriteLine(countRed);
                            Console.WriteLine("disarmed");
                        }
                        else
                        {
                            Console.WriteLine(countBlue);
                            Console.WriteLine("BOOM");
                        }
                    }
                }
                else
                {
                    int countRed = 0;
                    int countBlue = 0;

                    for (int row = 1; row < 15; row++)
                    {
                        for (int col = 1; col < 8; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;

                            int aboveRow = row - 1;
                            int belowRow = row + 1;

                            int beforeCol = col - 1;
                            int afterCol = col + 1;

                            bool topLeft = false;
                            bool topMiddle = false;
                            bool topRight = false;
                            bool currentLeft = false;
                            bool currentRight = false;
                            bool bottomLeft = false;
                            bool bottomMiddle = false;
                            bool bottomRight = false;

                            if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, belowRow] == 1)
                            {
                                topLeft = true;
                            }

                            if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                            {
                                topMiddle = true;
                            }

                            if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                            {
                                topRight = true;
                            }

                            if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                            {
                                currentLeft = true;
                            }

                            if (afterCol < 16 && board[currentRow, afterCol] == 1)
                            {
                                currentRight = true;
                            }

                            if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                            {
                                bottomLeft = true;
                            }

                            if (belowRow < 16 && board[belowRow, currentCol] == 1)
                            {
                                bottomMiddle = true;
                            }

                            if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                            {
                                bottomRight = true;
                            }

                            if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                            {
                                for (row = aboveRow; row < +belowRow; row++)
                                {
                                    for (col = beforeCol; col < +afterCol; col++)
                                    {
                                        countRed++;
                                    }
                                }
                            }
                        }
                    }
                    
                    for (int row = 1; row < 15; row++)
                    {
                        for (int col = 8; col < 15; col++)
                        {
                            int currentRow = row;
                            int currentCol = col;

                            int aboveRow = row - 1;
                            int belowRow = row + 1;

                            int beforeCol = col - 1;
                            int afterCol = col + 1;

                            bool topLeft = false;
                            bool topMiddle = false;
                            bool topRight = false;
                            bool currentLeft = false;
                            bool currentRight = false;
                            bool bottomLeft = false;
                            bool bottomMiddle = false;
                            bool bottomRight = false;

                            if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, belowRow] == 1)
                            {
                                topLeft = true;
                            }
                            if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                            {
                                topMiddle = true;
                            }
                            if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                            {
                                topRight = true;
                            }
                            if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                            {
                                currentLeft = true;
                            }
                            if (afterCol < 16 && board[currentRow, afterCol] == 1)
                            {
                                currentRight = true;
                            }
                            if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                            {
                                bottomLeft = true;
                            }
                            if (belowRow < 16 && board[belowRow, currentCol] == 1)
                            {
                                bottomMiddle = true;
                            }
                            if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                            {
                                bottomRight = true;
                            }

                            if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                            {
                                for (row = aboveRow; row < +belowRow; row++)
                                {
                                    for (col = beforeCol; col < +afterCol; col++)
                                    {
                                        countBlue++;
                                    }
                                }
                            }
                        }

                        if (countRed == 0)
                        {
                            Console.WriteLine(countBlue);
                            Console.WriteLine("disarmed");
                        }
                        else
                        {
                            Console.WriteLine(countRed);
                            Console.WriteLine("BOOM");
                        }
                    }

                    break;
                }

                if (currentOperation == "hover" || currentOperation == "operate")
                {
                    int currentRow = int.Parse(Console.ReadLine());
                    int currentCol = int.Parse(Console.ReadLine());

                    if (currentOperation == "hover")
                    {
                        int currentNumber = board[currentRow, currentCol];
                        if (currentNumber == 1)
                        {
                            Console.WriteLine('*');
                        }
                        else
                        {
                            Console.WriteLine('-');
                        }
                    }

                    if (currentOperation == "operate")
                    {
                        int currentNumber = board[currentRow, currentCol];
                        if (currentNumber == 1)
                        {
                            Console.WriteLine("missed");

                            int count = 0;
                            for (int row = 1; row < 15; row++)
                            {
                                for (int col = 1; col < 15; col++)
                                {
                                    int aboveRow = row - 1;
                                    int belowRow = row + 1;

                                    int beforeCol = col - 1;
                                    int afterCol = col + 1;

                                    bool topLeft = false;
                                    bool topMiddle = false;
                                    bool topRight = false;
                                    bool currentLeft = false;
                                    bool currentRight = false;
                                    bool bottomLeft = false;
                                    bool bottomMiddle = false;
                                    bool bottomRight = false;

                                    if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, belowRow] == 1)
                                    {
                                        topLeft = true;
                                    }

                                    if (aboveRow >= 0 && board[aboveRow, col] == 1)
                                    {
                                        topMiddle = true;
                                    }

                                    if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                                    {
                                        topRight = true;
                                    }

                                    if (beforeCol >= 0 && board[row, beforeCol] == 1)
                                    {
                                        currentLeft = true;
                                    }

                                    if (afterCol < 16 && board[row, afterCol] == 1)
                                    {
                                        currentRight = true;
                                    }

                                    if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                                    {
                                        bottomLeft = true;
                                    }

                                    if (belowRow < 16 && board[belowRow, col] == 1)
                                    {
                                        bottomMiddle = true;
                                    }

                                    if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                                    {
                                        bottomRight = true;
                                    }

                                    if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                                    {
                                        for (row = aboveRow; row < +belowRow; row++)
                                        {
                                            for (col = beforeCol; col < +afterCol; col++)
                                            {
                                                count++;
                                            }
                                        }
                                    }
                                }
                            }

                            Console.WriteLine(count);
                            Console.WriteLine("BOOM");
                            break;
                        }
                        else
                        {
                            int aboveRow = currentRow - 1;
                            int belowRow = currentRow + 1;

                            int beforeCol = currentCol - 1;
                            int afterCol = currentCol + 1;

                            bool topLeft = false;
                            bool topMiddle = false;
                            bool topRight = false;
                            bool currentLeft = false;
                            bool currentRight = false;
                            bool bottomLeft = false;
                            bool bottomMiddle = false;
                            bool bottomRight = false;

                            if (aboveRow >= 0 && beforeCol >= 0 && board[aboveRow, belowRow] == 1)
                            {
                                topLeft = true;
                            }
                            if (aboveRow >= 0 && board[aboveRow, currentCol] == 1)
                            {
                                topMiddle = true;
                            }
                            if (aboveRow >= 0 && afterCol < 16 && board[aboveRow, afterCol] == 1)
                            {
                                topRight = true;
                            }
                            if (beforeCol >= 0 && board[currentRow, beforeCol] == 1)
                            {
                                currentLeft = true;
                            }
                            if (afterCol < 16 && board[currentRow, afterCol] == 1)
                            {
                                currentRight = true;
                            }
                            if (belowRow < 16 && beforeCol >= 0 && board[belowRow, beforeCol] == 1)
                            {
                                bottomLeft = true;
                            }
                            if (belowRow < 16 && board[belowRow, currentCol] == 1)
                            {
                                bottomMiddle = true;
                            }
                            if (belowRow < 16 && afterCol < 16 && board[belowRow, afterCol] == 1)
                            {
                                bottomRight = true;
                            }

                            if (topLeft && topMiddle && topRight && currentLeft && currentRight && bottomLeft && bottomMiddle && bottomRight)
                            {
                                for (int row = aboveRow; row < +belowRow; row++)
                                {
                                    for (int col = beforeCol; col < +afterCol; col++)
                                    {
                                        board[row, col] = 0;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine();

            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    Console.Write(board[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}