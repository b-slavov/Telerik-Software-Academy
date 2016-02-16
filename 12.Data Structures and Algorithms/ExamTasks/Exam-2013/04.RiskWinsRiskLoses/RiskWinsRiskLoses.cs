namespace RiskWinsRiskLoses
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class RiskWinsRiskLoses
    {
        static void Main()
        {
            string startCombination = Console.ReadLine();
            string endCombination = Console.ReadLine();
            int forbiddenCombinationsCount = int.Parse(Console.ReadLine());
            HashSet<string> visited = new HashSet<string>();
            for (int i = 0; i < forbiddenCombinationsCount; i++)
            {
                visited.Add(Console.ReadLine());
            }

            Queue<Tuple<string, int>> queue = new Queue<Tuple<string, int>>();
            queue.Enqueue(new Tuple<string, int>(startCombination, 0));
            visited.Add(startCombination);
            while (queue.Count > 0)
            {
                var currentCombination = queue.Dequeue();
                if (currentCombination.Item1 == endCombination)
                {
                    Console.WriteLine(currentCombination.Item2);
                    return;
                }

                var stringBuilder = new StringBuilder(currentCombination.Item1);
                for (int i = 0; i < 5; i++)
                {
                    int digit = currentCombination.Item1[i] - '0';
                    digit++;
                    if (digit == 10)
                    {
                        digit = 0;
                    }

                    stringBuilder[i] = (char)(digit + '0');
                    string newNode = stringBuilder.ToString();
                    if (!visited.Contains(newNode))
                    {
                        visited.Add(newNode);
                        queue.Enqueue(new Tuple<string, int>(newNode, currentCombination.Item2 + 1));
                    }

                    stringBuilder[i] = currentCombination.Item1[i];
                }

                for (int i = 0; i < 5; i++)
                {
                    int digit = currentCombination.Item1[i] - '0';
                    digit--;
                    if (digit == -1)
                    {
                        digit = 9;
                    }

                    stringBuilder[i] = (char)(digit + '0');
                    string newNode = stringBuilder.ToString();
                    if (!visited.Contains(newNode))
                    {
                        visited.Add(newNode);
                        queue.Enqueue(new Tuple<string, int>(newNode, currentCombination.Item2 + 1));
                    }

                    stringBuilder[i] = currentCombination.Item1[i];
                }
            }

            Console.WriteLine(-1);
        }
    }
}