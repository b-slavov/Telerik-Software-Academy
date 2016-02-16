namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class LongestSubsequenceFinder
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 2, 1, 1, 2, 3, 3, 1, 1, 1, 2 };
            FindMaxSequence(numbers);
            List<int> secondSetOfNumbers = new List<int> { 1, 1, 1, 2, 3, 4, 3, 3, 2, 2, 2, 2 };
            FindMaxSequence(secondSetOfNumbers);
            List<int> thirdSetOfNumbers = new List<int> { 3, 1, 1, 2, 3, 3, 3, 3, 3, 1, 1, 3, 3, 2, 2 };
            FindMaxSequence(thirdSetOfNumbers);
        }

        private static void FindMaxSequence(List<int> numbers)
        {
            int currentSequence = 1;
            int maxSequence = 1;
            int maxSequenceStartIndex = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequence++;
                    if (i == numbers.Count - 1 && currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        maxSequenceStartIndex = i - maxSequence + 1;
                    }
                }
                else
                {
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        maxSequenceStartIndex = i - maxSequence;
                    }
                    currentSequence = 1;
                }
            }

            List<int> longestSequence = new List<int>();

            for (int i = 0; i < maxSequence; i++)
            {
                longestSequence.Add(numbers[maxSequenceStartIndex]);
            }

            Console.WriteLine("The longest subsequence in [{0}] is [{1}].", string.Join(", ", numbers), string.Join(", ", longestSequence));
        }
    }
}