using System;

class OneSystemToAnyOther
{
    static string ConvertNumeralSystem(string value, int base1, int base2)
    {
        long decRepresentation = 0;
        for (int i = value.Length - 1; i >= 0; i--)
        {
            if (char.IsDigit(value[i]))
            {
                decRepresentation += long.Parse(value[i].ToString()) * Power(base1, value.Length - i - 1);
            }
            else
            {
                long number = 0;

                switch (value[i])
                {
                    case 'A': number = 10; break;
                    case 'B': number = 11; break;
                    case 'C': number = 12; break;
                    case 'D': number = 13; break;
                    case 'E': number = 14; break;
                    case 'F': number = 15; break;
                }

                decRepresentation += number * Power(base1, value.Length - i - 1);
            }
        }

        long remainder;
        string result = string.Empty;
        while (decRepresentation > 0)
        {
            remainder = decRepresentation % base2;
            decRepresentation /= base2;
            if (remainder < 10)
            {
                result = remainder.ToString() + result;
            }
            else
            {
                switch (remainder)
                {
                    case 10: result = "A" + result; break;
                    case 11: result = "B" + result; break;
                    case 12: result = "C" + result; break;
                    case 13: result = "D" + result; break;
                    case 14: result = "E" + result; break;
                    case 15: result = "F" + result; break;
                }
            }
        }

        return result;
    }

    static long Power(long number, long power)
    {
        long result = 1;
        for (int i = 0; i < power; i++)
        {
            result *= number;
        }

        return result;
    }

    static void Main()
    {
        int base1 = int.Parse(Console.ReadLine());
        string numberInBase1 = Console.ReadLine();
        int base2 = int.Parse(Console.ReadLine());

        Console.WriteLine(ConvertNumeralSystem(numberInBase1, base1, base2));
    }
}
