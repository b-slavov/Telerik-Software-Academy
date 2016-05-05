using System;

class MaximalSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = array[0];
        int currentSum = array[0];
        int start = 0;
        int startTemp = 0;
        int end = 0;

        for (int i = 1; i < array.Length; i++)
        {
            currentSum += array[i];
            if (currentSum < array[i])
            {
                currentSum = array[i];
                startTemp = i;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }
        }

        Console.Write(maxSum);
    }
}
