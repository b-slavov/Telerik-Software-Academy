namespace Queue
{
    using System;

    using Queue.QueueImplementation;

    public class QueueUsage
    {
        static void Main()
        {
            var testQ = new CustomQueue<int>();
            testQ.Enqueue(1);
            testQ.Enqueue(2);
            testQ.Enqueue(3);

            while (testQ.Count > 0)
            {
                Console.WriteLine(testQ.Dequeue());
            }
        }
    }
}