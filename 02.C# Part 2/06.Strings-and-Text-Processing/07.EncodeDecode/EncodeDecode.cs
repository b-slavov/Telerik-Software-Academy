using System;
using System.Text;

class EncodeDecode
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.Write("Enter code: ");
        string code = Console.ReadLine();

        StringBuilder encripted = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            encripted.Append((char)(input[i] ^ code[i % code.Length]));
        }

        Console.WriteLine("Encripted: " + encripted);

        StringBuilder decript = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            decript.Append((char)(encripted[i] ^ code[i % code.Length]));
        }

        Console.WriteLine("Decripted: " + decript);
    }
}