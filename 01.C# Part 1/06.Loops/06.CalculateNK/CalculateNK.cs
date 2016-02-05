using System;

class CalculateNK
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int factorial = 1;

        for (int i = (k + 1); i <= n; i++)
        {
            factorial = factorial * i;
        }

        Console.WriteLine("n! / k! = " + factorial);
    }
}