using System;

class ExtractSentences
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();
        string[] sentences = Console.ReadLine().Split('.');

        int wordLength = word.Length;
        foreach (var sentence in sentences)
        {
            int sentenceLength = sentence.Length;
            string sentenceToLower = sentence.ToLower();
            for (int i = 0; i <= sentenceLength - wordLength; i++)
            {
                if (sentenceToLower.Substring(i, wordLength).Contains(word)
                    && (sentenceLength == wordLength
                        || (i == 0 && !char.IsLetter(sentenceToLower[i + wordLength]))
                        || (i == sentenceLength - wordLength && !char.IsLetter(sentenceToLower[i - 1]))
                        || (i > 0 && i < sentenceLength - wordLength && !char.IsLetter(sentenceToLower[i - 1]) && !char.IsLetter(sentenceToLower[i + wordLength]))))
                {
                    Console.Write(sentence + ".");
                    break;
                }
            }
        }

        Console.WriteLine();
    }
}
