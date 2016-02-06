using System;

class DecimalToHexadecimal
{
    static string DecimalToHexadecimalFunc(int number)
    {
        int remainder;
        string result = string.Empty;

        while (number > 0)
        {
            remainder = number % 16;
            number /= 16;

            if (remainder < 10)
            {
                result = remainder.ToString() + result;
            }
            else
            {
                switch (remainder)
                {
                    case 10:
                        result = "A" + result;
                        break;
                    case 11:
                        result = "B" + result;
                        break;
                    case 12:
                        result = "C" + result;
                        break;
                    case 13:
                        result = "D" + result;
                        break;
                    case 14:
                        result = "E" + result;
                        break;
                    case 15:
                        result = "F" + result;
                        break;
                    default:
                        break;
                }
            }

        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Hexadecimal representation: " + DecimalToHexadecimalFunc(number));
    }
}