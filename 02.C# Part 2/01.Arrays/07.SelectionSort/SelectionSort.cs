using System;

class SelectionSort
{
    static void Main()
    {
        int[] arr = { 13, 3, -1, 11, 39, 26, 9, 77, 45, 89 };
        for (int i = 0; i < arr.Length - 1; i++)
        {
            int smallestElement = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[smallestElement])
                {
                    smallestElement = j;
                }
            }

            if (smallestElement != i)
            {
                int temp = 0;
                temp = arr[i];
                arr[i] = arr[smallestElement];
                arr[smallestElement] = temp;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (i != arr.Length - 1)
            {
                Console.Write("{0}, ", arr[i]);
            }
            else
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}