using System;

class PermutationsOfSet
{
    static void Permute(int[] arr, bool[] used, int index)
    {
        if (index == arr.Length)
        {
            foreach (int element in arr)
            {
                Console.Write("{0} ", element + 1);
            }

            Console.WriteLine();
            return;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (!used[i])
            {
                arr[index] = i;
                used[i] = true;
                Permute(arr, used, index + 1);
                used[i] = false;
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        bool[] used = new bool[n];
        Permute(arr, used, 0);
    }
}