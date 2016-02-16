namespace ListSorting
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    public class ListSorter
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.Write("Enter a number of integers to be read: ");
            int numberOfIntegers;
            bool isNumberValid = int.TryParse(Console.ReadLine(), out numberOfIntegers);

            while (!isNumberValid || numberOfIntegers <= 0)
            {
                Console.WriteLine("Invalid positive integer, try again!");
                Console.Write("Enter a number of integers to be read: ");
                isNumberValid = int.TryParse(Console.ReadLine(), out numberOfIntegers);
            }

            var numbers = new List<int>();

            for (int i = 0; i < numberOfIntegers; i++)
            {
                Console.Write("Enter an integer: ");
                int currentNumber;
                isNumberValid = int.TryParse(Console.ReadLine(), out currentNumber);

                while (!isNumberValid)
                {
                    Console.Write("Invalid integer, try again: ");
                    isNumberValid = int.TryParse(Console.ReadLine(), out currentNumber);
                }

                numbers.Add(currentNumber);
            }

            numbers.Sort();
            Console.WriteLine("Sorted numbers: {0}", string.Join(", ", numbers));
        }
    }
}