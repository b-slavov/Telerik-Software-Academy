using System;

class HexadecimalToBinary
{
    static string HexadecimalToBinaryFunc(string number)
    {
        string result = string.Empty;

        for (int i = 0; i < number.Length; i++)
        {
            switch (number[i])
            {
                case '0':
                    result += "0000";
                    break;
                case '1':
                    result += "0001";
                    break;
                case '2':
                    result += "0010";
                    break;
                case '3':
                    result += "0011";
                    break;
                case '4':
                    result += "0100";
                    break;
                case '5':
                    result += "0101";
                    break;
                case '6':
                    result += "0110";
                    break;
                case '7':
                    result += "0111";
                    break;
                case '8':
                    result += "1000";
                    break;
                case '9':
                    result += "1001";
                    break;
                case 'A':
                case 'a':
                    result += "1010";
                    break;
                case 'B':
                case 'b':
                    result += "1011";
                    break;
                case 'C':
                case 'c':
                    result += "1100";
                    break;
                case 'D':
                case 'd':
                    result += "1101";
                    break;
                case 'E':
                case 'e':
                    result += "1110";
                    break;
                case 'F':
                case 'f':
                    result += "1111";
                    break;
                default:
                    break;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.Write("Enter hexadecimal number: ");
        string number = Console.ReadLine();

        Console.WriteLine("Binary representation: " + HexadecimalToBinaryFunc(number));
    }
}