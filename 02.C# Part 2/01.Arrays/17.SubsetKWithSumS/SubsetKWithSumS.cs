using System;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write("Enter sum of the subset: ");
        long wantedSum = long.Parse(Console.ReadLine());

        Console.Write("Enter length of the subset: ");
        int lenSub = int.Parse(Console.ReadLine());

        Console.Write("Enter number of elements: ");
        long numberOfElements = long.Parse(Console.ReadLine());

        long[] elements = new long[numberOfElements];
        int counter = 0;
        string subset = "";
        for (int i = 0; i < elements.Length; i++)
        {
            Console.Write("Element [{0}] = ", i + 1);
            elements[i] = long.Parse(Console.ReadLine());
        }

        int maxSubsets = (int)Math.Pow(2, numberOfElements);
        for (int i = 1; i < maxSubsets; i++)
        {
            subset = "";
            long checkingSum = 0;
            int lenCounter = 0;
            for (int j = 0; j <= numberOfElements; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    checkingSum = checkingSum + elements[j];
                    subset = subset + " " + elements[j];
                    lenCounter++;
                }
            }

            if (checkingSum == wantedSum && lenCounter == lenSub)
            {
                counter++;
                Console.WriteLine("Subset with sum of {0}:{1}", wantedSum, subset);
            }
        }

        Console.WriteLine("Total count of subsets: " + counter);
    }
}