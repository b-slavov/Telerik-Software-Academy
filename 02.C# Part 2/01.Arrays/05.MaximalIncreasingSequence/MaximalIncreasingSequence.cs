using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] arr = { 3, 2, 3, 4, 2, 2, 4 };
        int currentLenght = 1;
        int bestLenght = 0;
        int endIndex = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                currentLenght++;
            }
            else
            {
                if (currentLenght > bestLenght)
                {
                    bestLenght = currentLenght;
                    endIndex = i;
                }

                currentLenght = 1;
            }
        }

        if (currentLenght > bestLenght)
        {
            bestLenght = currentLenght;
            endIndex = arr.Length - 1;
        }

        currentLenght = 1;
        for (int i = endIndex - bestLenght + 1; i < endIndex + 1; i++)
        {
            if (i != endIndex)
            {
                Console.Write("{0}, ", arr[i]);
            }
            else
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}