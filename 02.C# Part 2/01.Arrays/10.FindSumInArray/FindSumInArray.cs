using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Element [{0}]: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter sum  S: ");
        int s = int.Parse(Console.ReadLine());
        int sum = 0;
        bool solution = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                sum += arr[j];
                if (sum == s)
                {
                    solution = true;
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("{0} ", arr[print]);
                    }

                    Console.WriteLine();
                }
            }

            sum = 0;
        }

        if (!solution)
        {
            Console.WriteLine("Ain't no sequnce with the sum of {0}!", s);
        }
    }
}