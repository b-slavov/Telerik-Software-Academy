using System;

class GetLargestNumber
{
    static int GetMax(int a, int b)
    {
        return (a >= b ? a : b);
    }

    static void Main()
    {
        Console.WriteLine("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("c = ");
        int c = int.Parse(Console.ReadLine());

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