using System;

class BinaryToDecimal
{
    static long BinaryToDecimalFunc(string number)
    {
        long result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += (long)((number[i] - '0') * Math.Pow(2, number.Length - i - 1));
        }

        return result;
    }

    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(BinaryToDecimalFunc(number));
    }
}
