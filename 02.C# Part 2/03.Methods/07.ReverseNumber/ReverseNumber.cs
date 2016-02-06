using System;
using System.Globalization;
using System.Threading;

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
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter decimal value: ");
        decimal number = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed: " + ReverseDigits(number));
    }
}