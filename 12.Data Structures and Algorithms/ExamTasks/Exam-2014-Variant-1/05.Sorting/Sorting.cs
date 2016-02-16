namespace Sorting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    
    public class Sorting
    {
        static void Main()
        {
            Console.ReadLine();
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int answer = Bfs(numbers, k);
            Console.WriteLine(answer);
        }

        private static int Bfs(int[] numbers, int k)
        {
            var visited = new Dictionary<int, int>();

            var queue = new Queue<int[]>();
            queue.Enqueue(numbers);
            visited.Add(GetHashCode(numbers), 0);

            while (queue.Count > 0)
            {
                var currentPermutation = queue.Dequeue();
                var currentPath = visited[GetHashCode(currentPermutation)];
                if (IsSorted(currentPermutation))
                {
                    return currentPath;
                }

                for (int i = 0; i <= numbers.Length - k; i++)
                {
                    var descendant = currentPermutation.Clone() as int[];
                    Array.Reverse(descendant, i, k);
                    if (!visited.ContainsKey(GetHashCode(descendant)))
                    {
                        visited.Add(GetHashCode(descendant), currentPath + 1);
                        queue.Enqueue(descendant);
                    }
                }
            }

            return -1;
        }

        private static int GetHashCode(int[] values)
        {
            int hash = 0;
            foreach (var value in values)
            {
                hash *= 8;
                hash += value;
            }

            return hash;
        }

        private static bool IsSorted(int[] permutation)
        {
            for (int i = 1; i < permutation.Length; i++)
            {
                if (permutation[i] < permutation[i - 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}