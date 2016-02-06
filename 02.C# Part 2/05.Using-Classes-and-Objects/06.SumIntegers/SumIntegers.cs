using System;

class SumIntegers
{
    static void Main()
    {
        Console.Write("Enter integer values, separated by space: ");
        string s = Console.ReadLine();
        string[] numbers = s.Split(' ');
        double sum = 0;

        foreach (string number in numbers)
        {
            sum += double.Parse(number);
        }

        Console.WriteLine("Sum = " + sum);
    }
}