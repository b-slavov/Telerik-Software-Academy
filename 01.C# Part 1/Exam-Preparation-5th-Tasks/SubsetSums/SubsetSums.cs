using System;

class SubsetSums
{
    static void Main()
    {
        long sum = long.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        long[] nums = new long[n];
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            nums[i] = long.Parse(Console.ReadLine());
        }

        int power = 1;
        for (int i = 1; i <= n; i++)
        {
            power *= 2;
        }
        power -= 1;

        for (int i = 1; i <= power; i++)
        {
            long currentSum = 0;
            for (int j = 0; j < n; j++)
            {
                int mask = 1 << j;
                int iAndMask = i & mask;
                int bit = iAndMask >> j;
                if (bit == 1)
                {
                    currentSum += nums[j];
                }
            }

            if (currentSum == sum)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}