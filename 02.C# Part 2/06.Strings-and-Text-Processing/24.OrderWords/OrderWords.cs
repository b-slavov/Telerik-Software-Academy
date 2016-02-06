using System;
using System.Linq;

class OrderWords
{
    static void Main()
    {
        Console.Write("Enter words separated by spaces: ");
        string[] words = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(words);

        Console.WriteLine("\nWords sorted in alphabetical order:\n{0}\n",
            string.Join("\n", words.Select(x => string.Format("- {0}", x))));
    }
}