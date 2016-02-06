using System;

class BinarySearch
{
    static void Search(int[] arr, int start, int end, int element)
    {
        if (end <= start)
        {
            Console.WriteLine("Not Found!");
            return;
        }
        else
        {
            int middle = start + (end - start) / 2;
            if (element < arr[middle])
            {
                Search(arr, start, middle - 1, element);
            }
            else if (element > arr[middle])
            {
                Search(arr, middle + 1, end, element);
            }
            else
            {
                Console.WriteLine("The index of {0} is {1}", element, middle);
                return;
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int index = 0; index < n; index++)
        {
            Console.Write("Enter element {0}: ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter element to search for: ");
        int element = int.Parse(Console.ReadLine());
        Array.Sort(arr);
        Search(arr, 0, arr.Length, element);
    }
}