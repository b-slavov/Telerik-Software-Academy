using System;

class SubstringInText
{
    static void Main()
    {
        string pattern = Console.ReadLine().ToLower();
        string input = Console.ReadLine().ToLower();

        int counter = 0;
        for (int i = 0; i <= input.Length - pattern.Length; i++)
        {
            if (input.Substring(i, pattern.Length) == pattern)
            {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
}
