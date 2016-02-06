using System;
using System.Globalization;
using System.Threading;

class NumberCalculations
{
    public static T Minimum<T>(params T[] numbers)
    {
        dynamic currentSmallest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < currentSmallest)
            {
                currentSmallest = numbers[i];
            }
        }

        return currentSmallest;
    }

    public static T Maximum<T>(params T[] numbers)
    {
        dynamic currentBiggest = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > currentBiggest)
            {
                currentBiggest = numbers[i];
            }
        }

        return currentBiggest;
    }

    public static T Sum<T>(params T[] numbers)
    {
        dynamic sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }

        return sum;
    }

    public static float Average<T>(params T[] numbers)
    {
        dynamic sum = Sum(numbers);
        return (float)(sum / numbers.Length);
    }

    public static T Product<T>(params T[] numbers)
    {
        dynamic product = 1;
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
        Console.Write("Minimum of 4.5, 6.3, 3.1, -1.4, 7.7, 9.8, 2.5 is: ");
        Console.WriteLine(Minimum(4.5, 6.3, 3.1, -1.4, 7.7, 9.8, 2.5));
        Console.Write("Maximum of 15.4, 62.7, 34.3, 9.1, -71.7, 73.2, 55.6, 91.4, 27.5, 46.1 is: ");
        Console.WriteLine(Maximum(15.4, 62.7, 34.3, 9.1, -71.7, 73.2, 55.6, 91.4, 27.5, 46.1));
        Console.Write("Sum of 12.2, 4.4, -17.6, 1.7, 35.5, 23.4, -11.8 is: ");
        Console.WriteLine(Sum(12.2, 4.4, -17.6, 1.7, 35.5, 23.4, -11.8));
        Console.Write("Average of 13.6, 1.7, 17.3, 4.9, 15.2, 2.4, 12.1, 3.3 is: ");
        Console.WriteLine(Average(13.6, 1.7, 17.3, 4.9, 15.2, 2.4, 12.1, 3.3));
        Console.Write("Product of 3.8, 5.5, 8.4, 2.1, 4.3 is: ");
        Console.WriteLine(Product(3.8, 5.5, 8.4, 2.1, 4.3));
        Console.WriteLine();
    }
}