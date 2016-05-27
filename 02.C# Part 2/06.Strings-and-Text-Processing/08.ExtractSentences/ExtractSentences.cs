using System;
using System.Linq;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string text = Console.ReadLine();

        char[] separators = text.Where(x => !char.IsLetter(x)).Distinct().ToArray();
        string[] sentences = text.Split('.');
        foreach (var sentence in sentences)
        {
            string[] words = sentence.Split(separators);
            if (words.Contains(word))
            {
                Console.Write(sentence.Trim() + ". ");
            }
        }

        Console.WriteLine();
    }
}
