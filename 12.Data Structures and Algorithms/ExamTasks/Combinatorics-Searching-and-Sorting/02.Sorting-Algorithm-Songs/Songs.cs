namespace CombinatoricsSearchingAndSortingAlgorithms
{
    using System;
    using System.Linq;

    class Songs
    {
        static long CountInversions(int[] array, int start, int end)
        {
            if (start + 1 == end)
            {
                return 0;
            }

            int middle = (start + end) / 2;
            long inversions = CountInversions(array, start, middle) + CountInversions(array, middle, end);

            int[] sortedArray = new int[end - start];
            int i = start;
            int j = middle;
            int k = 0;

            while (i < middle && j < end)
            {
                if (array[i] < array[j])
                {
                    sortedArray[k] = array[i];
                    i++;
                }
                else
                {
                    inversions += middle - i;
                    sortedArray[k] = array[j];
                    j++;
                }

                k++;
            }

            while (i < middle)
            {
                sortedArray[k] = array[i];
                i++;
                k++;
            }

            while (j < end)
            {
                sortedArray[k] = array[j];
                j++;
                k++;
            }

            for (k = 0; k < sortedArray.Length; k++)
            {
                array[start + k] = sortedArray[k];
            }

            return inversions;
        }

        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());

            var juryChart = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var ivanchoChart = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var orderedChart = new int[numberOfSongs + 1];

            for (int i = 0; i < numberOfSongs; i++)
            {
                orderedChart[juryChart[i]] = i;
            }

            for (int i = 0; i < numberOfSongs; i++)
            {
                ivanchoChart[i] = orderedChart[ivanchoChart[i]];
            }

            Console.WriteLine(CountInversions(ivanchoChart, 0, numberOfSongs));
        }
    }
}