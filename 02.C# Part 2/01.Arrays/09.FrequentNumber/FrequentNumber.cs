using System;

class FrequentNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxCount = int.MinValue;
        int currentCount = 1;
        int number = 0;
        Array.Sort(array);
        for (int i = 1; i < n; i++)
        {
            if (array[i] == array[i - 1])
            {
                currentCount++;
            }
            else
            {
                currentCount = 1;
            }

            if (currentCount > maxCount)
            {
                maxCount = currentCount;
                number = array[i];
            }
        }

        if (n == 1)
        {
            maxCount = 1;
            number = array[0];
        }

        Console.WriteLine("{0} ({1} times)", number, maxCount);
    }
}
