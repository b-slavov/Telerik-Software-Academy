using System;
using System.Linq;

class RemoveElementsFromArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        int[] lis = new int[n];
        for (int i = 0; i < n; i++)
        {
            lis[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] <= numbers[i])
                {
                    lis[i] = Math.Max(lis[i], lis[j] + 1);
                }
            }
        }

        Console.WriteLine(n - lis.Max());
    }
}
