using System;
using System.Linq;

class LargerThanNeighbours
{
    static int HowManyNumbersAreLargerThanNeighbours(int[] array)
    {
        int counter = 0;
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
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
        Console.WriteLine(HowManyNumbersAreLargerThanNeighbours(input));
    }
}
