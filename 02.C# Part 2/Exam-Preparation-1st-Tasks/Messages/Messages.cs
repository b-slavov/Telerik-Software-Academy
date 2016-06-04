using System;
using System.Numerics;

class Messages
{
    static string[] alphabet = new string[] { "cad", "xoz", "nop", "cyk", "min", "mar", "kon", "iva", "ogi", "yan" };

    static BigInteger GeorgeTheGreatToDecimal(string word)
    {
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
        string result = string.Empty;
        while (dec > 0)
        {
            int index = (int)(dec % 10);
            string subString = alphabet[index];
            result = subString + result;
            dec /= 10;
        }

        return result;
    }

    static void Main()
    {
        string a = Console.ReadLine();
        string sign = Console.ReadLine();
        string b = Console.ReadLine();

        BigInteger aToDecimal = GeorgeTheGreatToDecimal(a);
        BigInteger bToDecimal = GeorgeTheGreatToDecimal(b);

        BigInteger result = sign == "+" ? aToDecimal + bToDecimal: aToDecimal - bToDecimal;

        Console.WriteLine(DecimalToGeorgeTheGreat(result));
    }
}
