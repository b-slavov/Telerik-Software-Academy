using System;

class SelectionSort
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            int smallestElement = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[smallestElement])
                {
                    smallestElement = j;
                }
            }

            if (smallestElement != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[smallestElement];
                array[smallestElement] = temp;
            }
        }

        foreach (var number in array)
        {
            Console.WriteLine(number);
        }
    }
}
