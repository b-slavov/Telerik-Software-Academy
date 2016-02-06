﻿using System;

class HexadecimalToDecimal
{
    static int HexadecimalToDecimalFunc(string number)
    {
        int result = 0;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            if (Char.IsDigit(number[i]))
            {
                result += (int)((number[i] - '0') * Math.Pow(16, number.Length - i - 1));
            }
            else
            {
                int num = 0;

                switch (number[i])
                {
                    case 'a':
                    case 'A':
                        num = 10;
                        break;
                    case 'b':
                    case 'B':
                        num = 11;
                        break;
                    case 'c':
                    case 'C':
                        num = 12;
                        break;
                    case 'd':
                    case 'D':
                        num = 13;
                        break;
                    case 'e':
                    case 'E':
                        num = 14;
                        break;
                    case 'f':
                    case 'F':
                        num = 15;
                        break;
                    default:
                        break;
                }

                result += (int)(num * Math.Pow(16, number.Length - i - 1));
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string number = Console.ReadLine();

        Console.WriteLine("Decimal representation: " + HexadecimalToDecimalFunc(number));
    }
}