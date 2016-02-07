namespace DivisibleBy7And3
{
    using System;
    using System.Linq;

    public class DivisibleBy7And3
    {
        public static void Main()
        {
            int[] arrayOfNumbers = { 63, 7, 26, 3, 47, -5, 81, 42, 99 };

            // Lambda expression:
            var targetedNumbers = arrayOfNumbers.Where(x => x % 21 == 0);

            // LINQ query:
            // var targetedNumbers =
            //    from n in arrayOfNumbers
            //    where n % 21 == 0
            //    select n;
            foreach (var number in targetedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}