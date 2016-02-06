using System;
using System.Text.RegularExpressions;

class ForbiddenWords
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.Write("Enter forbidden words separated by comma and space: ");
        string[] forbiddenWords = Console.ReadLine().Trim().Split(',', ' ');

        foreach (string word in forbiddenWords)
        {
            input = Regex.Replace(input, word, new String('*', word.Length));
        }

        Console.WriteLine("Output: " + input);
    }
}