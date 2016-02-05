using System;
using System.Linq;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers separated by single space:");
        string input = Console.ReadLine();

        double[] numbers = input.Split(' ').Select(double.Parse).ToArray();
        double sum = numbers.Sum();

        Console.WriteLine("Sum: " + sum);
    }
}