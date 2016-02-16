namespace ReadIntegers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    public class IntegerReader
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            List<int> numbers = new List<int>();
            Console.Write("Enter a positive integer: ");
            string inputLine = Console.ReadLine();
            int currentNumber;

            while (inputLine != string.Empty)
            {
                if (int.TryParse(inputLine, out currentNumber) && currentNumber > 0)
                {
                    numbers.Add(currentNumber);
                }
                else
                {
                    Console.WriteLine("Not a valid positive integer, enter another!");
                }

                Console.Write("Enter a positive integer: ");
                inputLine = Console.ReadLine();
            }

            Console.WriteLine("Sum: {0}; Average: {1}", numbers.Sum(), numbers.Average());
        }
    }
}