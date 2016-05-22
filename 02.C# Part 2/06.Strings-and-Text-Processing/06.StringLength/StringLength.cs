using System;

class StringLength
{
    static void Main()
    {
        string text = Console.ReadLine();

        text = text.Replace("\\", string.Empty);
        text = text.PadRight(20, '*');

        Console.WriteLine(text);
    }
}
