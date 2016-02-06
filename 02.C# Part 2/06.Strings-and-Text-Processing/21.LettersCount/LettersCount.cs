using System;
using System.Linq;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        char[] letters = Console.ReadLine().ToCharArray();

        Dictionary<char, int> dict = new Dictionary<char, int>();

        foreach (char letter in letters)
        {
            if (!dict.ContainsKey(letter))
            {
                dict.Add(letter, 1);
            }
            else
            {
                dict[letter]++;
            }
        }

        Console.WriteLine("\nLetter occurence table:\n{0}\n",
            string.Join("\n", dict.Select(x => string.Format(@"'{0}' -> {1} time(s)", x.Key, x.Value)).ToArray()));
    }
}