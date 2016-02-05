using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        int remainder = a % b;

        while (remainder != 0)
        {
            a = b;
            b = remainder;
            remainder = a % b;
        }

        Console.WriteLine("GCD = " + b);
    }
}