namespace RangeExceptions
{
    using System;

    public class ExceptionDemo
    {
        public static void Main()
        {
            Console.Write("Enter a number: ");

            try
            {
                var number = int.Parse(Console.ReadLine());

                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>(1, 100);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.Write("Enter a date: ");
            var date = DateTime.Parse(Console.ReadLine());

            var startDate = new DateTime(1980, 1, 1);
            var endDate = new DateTime(2013, 12, 31);

            try
            {
                if (date.CompareTo(startDate) < 0 || date.CompareTo(endDate) > 0)
                {
                    throw new InvalidRangeException<DateTime>(startDate, endDate);
                }
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
        }
    }
}