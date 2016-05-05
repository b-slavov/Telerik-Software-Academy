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
        
        string word = Console.ReadLine().ToLower();

        foreach (char letter in word)
        {
            Console.WriteLine(Array.IndexOf(alphabet, letter));
        }
    }
}
