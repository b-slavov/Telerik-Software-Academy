namespace DynamicProgramming
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Election
    {
        private static BigInteger Solve(List<int> parties, int k)
        {
            var sums = new BigInteger[parties.Sum() + 1];
            sums[0] = 1;
            var maxSum = 0;

            for (int i = 0; i < parties.Count; i++)
            {
                var number = parties[i];
                for (int j = maxSum; j >= 0; j--)
                {
                    if (sums[j] > 0)
                    {
                        sums[j + number] += sums[j];
                        maxSum = Math.Max(j + number, maxSum);
                    }
                }
            }

            BigInteger combinations = 0;
            for (int i = k; i <= parties.Sum(); i++)
            {
                combinations += sums[i];
            }

            return combinations;
        }

        public static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            var parties = new List<int>();
            for (int i = 0; i < n; i++)
            {
                parties.Add(int.Parse(Console.ReadLine()));
            }

            BigInteger answer = Solve(parties, k);
            Console.WriteLine(answer);
        }
    }
}