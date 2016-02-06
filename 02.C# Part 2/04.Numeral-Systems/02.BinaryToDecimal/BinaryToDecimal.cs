using System;

class BinaryToDecimal
{
    static int BinaryToDecimalFunc(string number)
    {
        int result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            result += (int)((number[i] - '0') * Math.Pow(2, number.Length - i - 1));
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter binary number: ");
        string number = Console.ReadLine();

        Console.WriteLine("Decimal representation: " + BinaryToDecimalFunc(number));
    }
}