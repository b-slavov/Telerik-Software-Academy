using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger numerator = 1;
        BigInteger denuminator = 1;

        for (int i = (n + 2); i <= (2 * n); i++)
        {
            numerator *= i;
        }

        for (int i = 1; i <= n; i++)
        {
            denuminator *= i;
        }

        Console.WriteLine(numerator / denuminator);
    }
}