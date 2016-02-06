using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        Console.Write("Enter the first date (dd.MM.yyyy): ");
        string startDate = Console.ReadLine();
        Console.Write("Enter the second date (dd.MM.yyyy): ");
        string endDate = Console.ReadLine();

        DateTime start = DateTime.ParseExact(startDate, "d.M.yyyy", CultureInfo.InvariantCulture);
        DateTime end = DateTime.ParseExact(endDate, "d.M.yyyy", CultureInfo.InvariantCulture);

        Console.WriteLine("Distance: {0} days", Math.Abs((end - start).TotalDays));
    }
}