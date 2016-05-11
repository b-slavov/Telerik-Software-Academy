using System;
using System.Linq;

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
        Console.ReadLine();
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine(NumberAppearancesCounter(input, number));
    }
}
