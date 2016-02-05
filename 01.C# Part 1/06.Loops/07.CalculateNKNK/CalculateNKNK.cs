using System;
using System.Numerics;

class CalculateNKNK
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger denuminator = 1;

        for (int i = (k + 1); i <= n; i++)
        {
            numerator = numerator * i;
        }

        for (int j = 1; j <= (n - k); j++)
        {
            denuminator = denuminator * j;
        }

        Console.WriteLine("n! / (k! * (n-k)!) = " + (numerator / denuminator));
    }
}