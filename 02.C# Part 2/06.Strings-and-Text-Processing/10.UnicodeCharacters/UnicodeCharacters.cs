using System;

class UnicodeCharacters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string inputText = Console.ReadLine();

        foreach (char symbol in inputText)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }

        Console.WriteLine();
    }
}