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
                case '0': result += i == 0 ? "0" : "0000"; break;
                case '1': result += i == 0 ? "1" : "0001"; break;
                case '2': result += i == 0 ? "10" : "0010"; break;
                case '3': result += i == 0 ? "11" : "0011"; break;
                case '4': result += i == 0 ? "100" : "0100"; break;
                case '5': result += i == 0 ? "101" : "0101"; break;
                case '6': result += i == 0 ? "110" : "0110"; break;
                case '7': result += i == 0 ? "111" : "0111"; break;
                case '8': result += "1000"; break;
                case '9': result += "1001"; break;
                case 'A': result += "1010"; break;
                case 'B': result += "1011"; break;
                case 'C': result += "1100"; break;
                case 'D': result += "1101"; break;
                case 'E': result += "1110"; break;
                case 'F': result += "1111"; break;
            }
        }

        return result;
    }

    static void Main()
    {
        string number = Console.ReadLine();

        Console.WriteLine(HexadecimalToBinaryFunc(number));
    }
}
