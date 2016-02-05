using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] cardFaces = { " 2", " 3", " 4", " 5", " 6", " 7", " 8", " 9", "10", " J", " Q", " K", " A" };
        char[] cardSuits = { '\u2663', '\u2666', '\u2665', '\u2660' };

        for (int i = 0; i < cardFaces.Length; i++)
        {
            for (int j = 0; j < cardSuits.Length; j++)
            {
                Console.Write(j != cardSuits.Length - 1 ? cardFaces[i] + cardSuits[j] + " " : cardFaces[i] + cardSuits[j] + "\n");
            }
        }
    }
}