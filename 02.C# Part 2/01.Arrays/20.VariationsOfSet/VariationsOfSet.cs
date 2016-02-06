using System;

class VariationsOfSet
{
    static void Variations(int[] arr, int index, int elements)
    {
        if (index == arr.Length)
        {
            PrintResult(arr);
        }
        else
        {
            for (int i = 1; i <= elements; i++)
            {
                arr[index] = i;
                Variations(arr, index + 1, elements);
            }
        }
    }

    static void PrintResult(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write("{0} ", element);
        }

        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[k];
        Variations(arr, 0, n);
    }
}