using System;
using System.Globalization;
using System.Text;

class DateInBulgarian
{
    static void Main()
    {
        Console.Write("Enter a date and time in the format [dd.MM.yyyy HH:mm:ss]: ");
        string inputDateTime = Console.ReadLine();

        Console.InputEncoding = Encoding.UTF8;
        DateTime afterSixHoursAndHalf = DateTime.Parse(inputDateTime).AddHours(6).AddMinutes(30);
        var culture = new CultureInfo("bg-BG");

        Console.WriteLine("{0} {1:dd.MM.yyyy HH:mm:ss}", culture.DateTimeFormat.GetDayName(afterSixHoursAndHalf.DayOfWeek), afterSixHoursAndHalf);
    }
}