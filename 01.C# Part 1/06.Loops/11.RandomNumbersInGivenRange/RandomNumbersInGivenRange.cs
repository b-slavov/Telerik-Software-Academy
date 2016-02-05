using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("min = ");
        int minInt = int.Parse(Console.ReadLine());
        Console.Write("max = ");
        int maxInt = int.Parse(Console.ReadLine());

        Console.Write("random numbers: ");
        if (minInt <= maxInt)
        {
            Random random = new Random();
            for (int index = 0; index < n; index++)
            {
                Console.Write("{0} ", random.Next(minInt, maxInt + 1));
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("incorrect input");
        }
    }
}