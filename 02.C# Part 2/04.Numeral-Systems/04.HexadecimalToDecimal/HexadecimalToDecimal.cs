using System;

class HexadecimalToDecimal
{
    static long HexadecimalToDecimalFunc(string number)
    {
        long result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(number[i]))
            {
                result += (long)((number[i] - '0') * Math.Pow(16, number.Length - i - 1));
            }
            else
            {
                long num = 0;
                switch (number[i])
                {
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                }

                result += (long)(num * Math.Pow(16, number.Length - i - 1));
            }
        }

        return result;
    }

    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(HexadecimalToDecimalFunc(number));
    }
}
