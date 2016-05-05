using System;
using System.Collections.Generic;

class QuickSort
{
    static List<int> QuickSortEmpement(List<int> unsortedList)
    {
        if (unsortedList.Count <= 1)
        {
            return unsortedList;
        }

        int pivot = unsortedList.Count / 2;
        int pivotValue = unsortedList[pivot];
        unsortedList.RemoveAt(pivot);
        List<int> lesser = new List<int>();
        List<int> greater = new List<int>();
        foreach (int element in unsortedList)
        {
            if (element <= pivotValue)
            {
                lesser.Add(element);
            }
            else
            {
                greater.Add(element);
            }
        }

        List<int> result = new List<int>();
        result.AddRange(QuickSortEmpement(lesser));
        result.Add(pivotValue);
        result.AddRange(QuickSortEmpement(greater));
        return result;

    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> array = new List<int>();
        for (int i = 0; i < n; i++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }

        List<int> sortedArray = QuickSortEmpement(array);
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }
    }
}
