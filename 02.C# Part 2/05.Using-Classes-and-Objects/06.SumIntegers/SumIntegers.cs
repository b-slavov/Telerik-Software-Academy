using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        int[] integers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(integers.Sum());
    }
}
