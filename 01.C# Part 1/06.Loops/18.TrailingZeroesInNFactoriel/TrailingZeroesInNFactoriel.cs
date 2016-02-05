using System;

class TrailingZeroesInNFactoriel
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int zeroCount = 0;
        int d;

        for (int i = 5; i <= n; i += 5)
        {
            d = i;
            while (d % 5 == 0)
            {
                d /= 5;
                zeroCount++;
            }
        }

        Console.WriteLine("Trailing zeroes of n!: " + zeroCount);
    }
}