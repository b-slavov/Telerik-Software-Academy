using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static int CheckFirstLargerThanNeighbours(int[] array)
    {
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i - 1] && array[i] > array[i + 1])
            {
                return i;
            }
        }

        return -1;
    }

    static void Main()
    {
        Console.ReadLine();
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(CheckFirstLargerThanNeighbours(input));
    }
}
