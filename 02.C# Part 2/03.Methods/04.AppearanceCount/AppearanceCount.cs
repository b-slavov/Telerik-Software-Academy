using System;

class AppearanceCount
{
    static int NumberAppearancesCounter(int[] numberArray, int number)
    {
        int counter = 0;
        foreach (int digit in numberArray)
        {
            if (digit == number)
            {
                counter++;
            }
        }

        return counter;
    }

    static void Main()
    {
        int[] arr = { 3, 5, 4, 2, 3, 1, 3, 6, 3, 3, 1, 7, 3, 1, 3, 3, 3, 5, 8, 6, 9, 4, 2, 3, 1, 3, 3, 3, 7, 3 };
        Console.WriteLine("Digit 3 appears {0} times in the array", NumberAppearancesCounter(arr, 3));
    }
}