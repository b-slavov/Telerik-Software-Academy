using System;

class MaximalSequence
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
        int currentLenght = 1;
        int bestLenght = 0;
        int bestLenghtElement = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                currentLenght++;
            }
            else
            {
                if (currentLenght > bestLenght)
                {
                    bestLenght = currentLenght;
                    bestLenghtElement = arr[i];
                }

                currentLenght = 1;
            }
        }

        if (currentLenght > bestLenght)
        {
            bestLenght = currentLenght;
            bestLenghtElement = arr[arr.Length - 1];
        }

        int[] bestArray = new int[bestLenght];
        for (int i = 0; i < bestLenght; i++)
        {
            bestArray[i] = bestLenghtElement;
            if (i != bestArray.Length - 1)
            {
                Console.Write(bestArray[i] + ", ");
            }
            else
            {
                Console.WriteLine(bestArray[i]);
            }
        }
    }
}