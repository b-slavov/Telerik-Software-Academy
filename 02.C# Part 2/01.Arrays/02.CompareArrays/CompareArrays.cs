using System;

class CompareArrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                Console.WriteLine("Not equal");
                break;
            }
            else if (i == n - 1 && firstArray[i] == secondArray[i])
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
