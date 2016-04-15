using System;

class CalculateGCD
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(' ');
        int a = int.Parse(array[0]);
        int b = int.Parse(array[1]);

        int remainder = a % b;

        while (remainder != 0)
        {
            a = b;
            b = remainder;
            remainder = a % b;
        }

        Console.WriteLine(Math.Abs(b));
    }
}