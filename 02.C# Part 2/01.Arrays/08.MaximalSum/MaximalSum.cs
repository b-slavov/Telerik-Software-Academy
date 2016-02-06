using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter a sequence: ");
        int[] arr = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        int maxSum = arr[0];
        int currentSum = arr[0];
        int start = 0;
        int startTemp = 0;
        int end = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            currentSum += arr[i];
            if (currentSum < arr[i])
            {
                currentSum = arr[i];
                startTemp = i;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }
        }

        Console.Write("The sequence with maximal sum is: ");
        for (int i = start; i <= end; i++)
        {
            if (i != end)
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