using System;

class ReverseNumber
{
    static decimal ReverseDigits(decimal value)
    {
        char[] ch = value.ToString().ToCharArray();
        Array.Reverse(ch);

        return decimal.Parse(new string(ch));
    }

    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine(ReverseDigits(number));
    }
}
