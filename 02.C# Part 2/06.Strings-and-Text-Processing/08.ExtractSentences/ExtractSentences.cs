using System;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.Write("Enter word: ");
        string word = Console.ReadLine();

        string[] sentances = input.Split('.');

        foreach (var sentance in sentances)
        {
            if (sentance.Contains(' ' + word + ' '))
            {
                Console.Write(sentance + ".");
            }
        }

        Console.WriteLine();
    }
}