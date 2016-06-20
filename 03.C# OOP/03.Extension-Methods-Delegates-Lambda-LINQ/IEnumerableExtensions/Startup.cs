namespace IEnumerableExtensions
{
    using System;
    using System.Globalization;
    using System.Threading;

    public static class Startup
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            int[] arrayOfNumbers = { 7, -3, 1, 9, 5 };

            Console.WriteLine(string.Join(", ", arrayOfNumbers));
            Console.WriteLine("Sum = {0}", arrayOfNumbers.Sum());
            Console.WriteLine("Product = {0}", arrayOfNumbers.Product());
            Console.WriteLine("Min = {0}", arrayOfNumbers.Min());
            Console.WriteLine("Max = {0}", arrayOfNumbers.Max());
            Console.WriteLine("Average =  {0:F2}", arrayOfNumbers.Average());          
        }
    }
}
