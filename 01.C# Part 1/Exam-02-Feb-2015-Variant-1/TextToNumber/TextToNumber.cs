using System;
using System.Numerics;

class TextToNumber
{
    static void Main()
    {
        long m = long.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        BigInteger result = 0;

        foreach (char symbol in text)
        {
            if (symbol == 64)
            {
                break;
            }
            if ((symbol) >= 65 && (symbol) <= 90)
            {
                result += (symbol - 65);
            }
            if ((symbol) >= 97 && (symbol) <= 122)
            {
                result += (symbol - 97);
            }
            if ((symbol) >= 32 && (symbol) <= 47)
            {
                result %= m;
            }
            if ((symbol) >= 48 && (symbol) <= 57)
            {
                result *= (int)(symbol - 48);
            }
            if ((symbol) >= 58 && (symbol) <= 63)
            {
                result %= m;
            }
            if ((symbol) >= 91 && (symbol) <= 96)
            {
                result %= m;
            }
            if ((symbol) >= 123 && (symbol) <= 126)
            {
                result %= m;
            }
        }

        Console.WriteLine(result);
    }
}
