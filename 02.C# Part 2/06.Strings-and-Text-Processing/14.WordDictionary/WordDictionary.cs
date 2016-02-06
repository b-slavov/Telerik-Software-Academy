using System;

class WordDictionary
{
    static void Main()
    {
        string[,] dictionary =
            {
                {".NET", "platform for applications from Microsoft"},
                {"CLR", "managed execution environment for .NET"},
                {"namespace", "hierarchical organization of classes"}
            };

        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        string output = "Not found!";

        for (int i = 0; i < dictionary.GetLength(0); i++)
        {
            if (input == dictionary[i, 0])
            {
                output = dictionary[i, 1];
                break;
            }
        }

        Console.WriteLine(output);
    }
}