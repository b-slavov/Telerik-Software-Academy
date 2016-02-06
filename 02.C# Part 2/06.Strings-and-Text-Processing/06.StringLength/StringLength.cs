using System;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter a string of maximum 20 characters: ");
        string text = Console.ReadLine();

        if (text.Length <= 20)
        {
            text = text.PadRight(20, '*');
            Console.WriteLine(text);
        }
        else
        {
            Console.WriteLine("You entered more than 20 characters!");
        }
    }
}