using System;

class DecimalToBinary
{
    static string DecimalToBinaryFunc(long number)
    {
        long remainder;
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
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine(DecimalToBinaryFunc(number));
    }
}
