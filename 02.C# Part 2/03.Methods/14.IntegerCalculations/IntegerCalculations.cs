using System;
using System.Linq;
using System.Numerics;

class IntegerCalculations
{
    public static int Minimum(int[] intArray)
    {
        int currentSmallest = int.MaxValue;
        for (int i = 0; i < intArray.Length; i++)
        {
            if (intArray[i] < currentSmallest)
            {
                currentSmallest = intArray[i];
            }
        }

        return currentSmallest;
    }

    public static int Maximum(int[] numbers)
    {
        int currentBiggest = int.MinValue;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > currentBiggest)
            {
                currentBiggest = numbers[i];
            }
        }

        return currentBiggest;
    }

    public static int Sum(int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public static float Average(int[] numbers)
    {
        return (float)Sum(numbers) / numbers.Length;
    }

    public static BigInteger Product(int[] numbers)
    {
        BigInteger product = 1;
        foreach (var num in numbers)
        {
            product *= num;
        }

        return product;
    }

    static void Main()
    {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Console.WriteLine(Minimum(input));
        Console.WriteLine(Maximum(input));
        Console.WriteLine("{0:F2}", Average(input));
        Console.WriteLine(Sum(input));
        Console.WriteLine(Product(input));
    }
}
