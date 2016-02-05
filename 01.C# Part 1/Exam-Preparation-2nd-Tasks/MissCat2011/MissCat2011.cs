using System;

class MissCat2011
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] cat = new int[11];

        for (int i = 1; i <= n; i++)
        {
            byte vote = byte.Parse(Console.ReadLine());
            cat[vote]++;
        }

        int bestCat = 0;
        int bestCatVotes = 0;

        for (int i = 1; i <= 10; i++)
        {
            if (cat[i] > bestCatVotes)
            {
                bestCat = i;
                bestCatVotes = cat[i];
            }
        }

        Console.WriteLine(bestCat);
    }
}