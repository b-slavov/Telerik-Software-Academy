namespace Sequence
{
    using System;
    using System.Collections.Generic;

    public class SequenceCreator
    {
        public static void Main()
        {
            PrintSequence(2, 50);
        }

        private static void PrintSequence(int start, int targetSequenceLength)
        {
            Queue<int> container = new Queue<int>();
            container.Enqueue(start);
            var result = new Queue<int>();

            while (result.Count < targetSequenceLength)
            {
                int currentBase = container.Dequeue();
                result.Enqueue(currentBase);
                container.Enqueue(currentBase + 1);
                container.Enqueue(2 * currentBase + 1);
                container.Enqueue(currentBase + 2);
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}