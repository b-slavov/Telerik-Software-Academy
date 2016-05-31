using System;
using System.Numerics;

class Messages
{
    static void Main()
    {
        string a = Console.ReadLine();
        string operation = Console.ReadLine();
        string b = Console.ReadLine();

        BigInteger numberA = GeorgeTheGreatToDecimal(a);
        BigInteger numberB = GeorgeTheGreatToDecimal(b);

        BigInteger result = 0;
        if (operation == "+")
        {
            result = numberA + numberB;
        }
        else
        {
            result = numberA - numberB;
        }

        string output = DecimalToGeorgeTheGreat(result);

        Console.WriteLine(output);
    }

    static BigInteger GeorgeTheGreatToDecimal(string word)
    {
        string[] alphabet = new string[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        BigInteger result = 0;
        for (int i = 0; i < word.Length; i += 3)
        {
            string str = word.Substring(i, 3);
            BigInteger decimalValue = Array.IndexOf(alphabet, str);
            result = decimalValue + result * 10;
        }

        return result;
    }

    static string DecimalToGeorgeTheGreat(BigInteger dec)
    {
        string[] alphabet = new string[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

        string result = string.Empty;
        do
        {
            int index = (int)(dec % 10);
            string subString = alphabet[index];
            result = subString + result;
            dec /= 10;

        } while (dec > 0);

        return result;
    }
}
