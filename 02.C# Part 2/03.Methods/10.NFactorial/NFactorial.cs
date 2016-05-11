using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i + 1;
        }

        Console.WriteLine(CalcualteFactorial(numbers, n));

    }

    static BigInteger CalcualteFactorial(int[] array, int n)
    {
        BigInteger result = 1;
        for (int i = 0; i < n; i++)
        {
            result = result * array[i];
        }

        return result;
    }
}
