namespace Towns
{
    using System;
    using System.Collections.Generic;

    public class Towns
    {
        static void Main()
        {
            int numberOfTowns = int.Parse(Console.ReadLine());
            var population = new List<int>();
            for (int i = 0; i < numberOfTowns; i++)
            {
                population.Add(int.Parse(Console.ReadLine().Split(' ')[0]));
            }

            Console.WriteLine(Solve(population));
        }

        private static int Solve(List<int> population)
        {
            var leftToRightMaxIncreasingSequence = new int[population.Count];
            for (int i = 0; i < population.Count; i++)
            {
                int maxLength = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (population[j] < population[i])
                    {
                        maxLength = Math.Max(maxLength, leftToRightMaxIncreasingSequence[j]);
                    }
                }

                leftToRightMaxIncreasingSequence[i] = maxLength + 1;
            }

            var rightToLeftMaxIncreasingSequence = new int[population.Count];
            for (int i = population.Count - 1; i >= 0; i--)
            {
                int maxLength = 0;
                for (int j = population.Count - 1; j > i; j--)
                {
                    if (population[j] < population[i])
                    {
                        maxLength = Math.Max(maxLength, rightToLeftMaxIncreasingSequence[j]);
                    }
                }

                rightToLeftMaxIncreasingSequence[i] = maxLength + 1;
            }

            int maxPath = 0;
            for (int i = 0; i < population.Count; i++)
            {
                int currentPath = leftToRightMaxIncreasingSequence[i] + rightToLeftMaxIncreasingSequence[i] - 1;
                maxPath = Math.Max(maxPath, currentPath);
            }

            return maxPath;
        }
    }
}