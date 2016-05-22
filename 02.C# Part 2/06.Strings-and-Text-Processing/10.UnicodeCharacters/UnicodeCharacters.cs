using System;

class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();

        foreach (char symbol in text)
        {
            Console.Write("\\u{0:X4}", (int)symbol);
        }

        Console.WriteLine();
    }
}
