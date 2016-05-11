using System;
using System.Linq;

class GetLargestNumber
{
    static int GetMax(int a, int b)
    {
        return (a >= b ? a : b);
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int a = input[0];
        int b = input[1];
        int c = input[2];

        if (GetMax(a, b) > c)
        {
            Console.WriteLine(GetMax(a, b));
        }
        else
        {
            Console.WriteLine(c);
        }
    }
}
