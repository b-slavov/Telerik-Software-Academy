using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)(i + 'a');
        }

        Console.Write("Enter word: ");
        string word = Console.ReadLine().ToLower();

        foreach (char letter in word)
        {
            for (int i = 0; i < 26; i++)
            {
                if (letter == alphabet[i])
                {
                    Console.WriteLine("The index of '{0}' is {1}", letter, i);
                }
            }
        }
    }
}