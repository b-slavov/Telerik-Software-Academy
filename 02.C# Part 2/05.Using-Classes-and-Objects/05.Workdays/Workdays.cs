using System;
using System.Globalization;
using System.Threading;

class Workdays
{
    static DateTime[] holidays =
        {
            new DateTime(2015, 3, 3),
            new DateTime(2015, 4, 10),
            new DateTime(2015, 4, 13),
            new DateTime(2015, 5, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2015, 10, 22),
            new DateTime(2015, 12, 24),
            new DateTime(2015, 12, 25),
            new DateTime(2015, 12, 31)
        };

    static bool IsHoliday(DateTime date)
    {
        bool result = false;

        foreach (var day in holidays)
        {
            if (date.Year == day.Year && date.Month == day.Month && date.Day == day.Day)
                return true;
        }

        return result;
    }

    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter date (mm/dd/yyyy): ");
        DateTime endDate;
        DateTime startDate = DateTime.Now;
        double workDays = 0;

        if (DateTime.TryParse(Console.ReadLine(), out endDate))
        {
            if (DateTime.Compare(endDate, startDate) < 0)
            {
                Console.WriteLine("Enter date should be after today!");
                return;
            }

            while (startDate.Year != endDate.Year || startDate.Month != endDate.Month || startDate.Day != endDate.Day)
            {
                if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday && IsHoliday(startDate) == false)
                {
                    workDays++;
                }

                startDate = startDate.AddDays(1);
            }

            Console.WriteLine("Workdays between today and {0:MM/dd/yyyy} -> {1}", endDate, workDays);
        }
        else
        {
            Console.WriteLine("Invalid date!");
        }
    }
}