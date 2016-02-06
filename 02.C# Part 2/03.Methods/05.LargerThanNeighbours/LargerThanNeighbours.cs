using System;

class LargerThanNeighbours
{
    static bool CheckIfLargerThanNeighbours(int[] array, int index)
    {
        if ((index <= 0) || (index >= array.Length - 1))
        {
            return false;
        }
        else if ((array[index] > array[index + 1]) && (array[index] > array[index - 1]))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int[] arr = { 3, 5, 4, 2, 3, 1, 3, 6, 3, 3, 1, 7, 3, 1, 3, 3, 3, 5, 8, 6, 9, 4, 2, 3, 1, 3, 3, 3, 7, 3 };
        Console.Write("Enter position: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} is larger than {1} and {2} -> {3}", arr[x], arr[x - 1], arr[x + 1], CheckIfLargerThanNeighbours(arr, x));
    }
}