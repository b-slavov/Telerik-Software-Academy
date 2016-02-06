using System;
using System.Numerics;

class NFactorial
{
    static void Main()
    {
        int[] numbersFromOneToHundred = new int[100];
        for (int i = 0; i < 100; i++)
        {
            numbersFromOneToHundred[i] = i + 1;
        }

        foreach (int number in numbersFromOneToHundred)
        {
            Console.WriteLine(CalcualteFactorial(numbersFromOneToHundred, number));
        }

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