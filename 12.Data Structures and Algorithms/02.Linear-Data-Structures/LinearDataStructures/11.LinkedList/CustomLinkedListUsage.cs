namespace LinkedList
{
    using System;

    using LinkedList.LinkedListImplementation;

    public class CustomLinkedListUsage
    {
        static void Main()
        {
            var testList = new CustomLinkedList<string>();
            testList.Add("First");
            testList.Add("Last");
            testList.AddFirst("New first");
            testList.AddLast("New last");

            Console.WriteLine("Linked list contents: {0}\n", string.Join(" --> ", testList));

            testList.RemoveFirst();
            testList.RemoveLast();

            Console.WriteLine("After removing New First and New Last: ");
            Console.WriteLine("Linked list contents: {0}\n", string.Join(" --> ", testList));

            testList.Add("Some value");
            testList.Remove("Last");

            Console.WriteLine("After adding Some value and removing Last by value: ");
            Console.WriteLine("Linked list contents: {0}\n", string.Join(" --> ", testList));
        }
    }
}