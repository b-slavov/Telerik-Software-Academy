using System;

class DecimalToBinary
{
    static string DecimalToBinaryFunc(int number)
    {
        int remainder;
        string result = string.Empty;

        while (number > 0)
        {
            remainder = number % 2;
            number /= 2;
            result = remainder.ToString() + result;
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation: " + DecimalToBinaryFunc(number));
    }
}