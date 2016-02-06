using System;
using System.Globalization;
using System.Numerics;
using System.Threading;

class IntegerCalculations
{
    public static int Minimum(params int[] intArray)
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

    public static int Maximum(params int[] numbers)
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

    public static int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public static float Average(params int[] numbers)
    {
        return (float)Sum(numbers) / numbers.Length;
    }

    public static BigInteger Product(params int[] numbers)
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
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Using variable number of arguments\n");
        Console.Write("Minimum of 4, 6, 3, -1, 7, 9, 2 is: ");
        Console.WriteLine(Minimum(4, 6, 3, -1, 7, 9, 2));
        Console.Write("Maximum of 15, 62, 34, 9, -71, 73, 55, 91, 27, 46 is: ");
        Console.WriteLine(Maximum(15, 62, 34, 9, -71, 73, 55, 91, 27, 46));
        Console.Write("Sum of 12, 4, -17, 1, 35, 23, -11 is: ");
        Console.WriteLine(Sum(12, 4, -17, 1, 35, 23, -11));
        Console.Write("Average of 13, 1, 17, 4, 15, 2, 12, 3 is: ");
        Console.WriteLine(Average(13, 1, 17, 4, 15, 2, 12, 3));
        Console.Write("Product of 3, 5, 8, 2, 4 is: ");
        Console.WriteLine(Product(3, 5, 8, 2, 4));
        Console.WriteLine();
    }
}