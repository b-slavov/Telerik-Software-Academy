using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

class DatesFromTextInCanada
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");

        string text = "13.11.2015 6.6.06 07.7.2007 8.08.2008";

        string format = "d.M.yyyy";
        CultureInfo provider = Thread.CurrentThread.CurrentCulture;

        foreach (var match in Regex.Matches(text, @"[\d]{1,2}.[\d]{1,2}.[\d]{4}"))
        {
            try
            {
                DateTime check = DateTime.ParseExact(match.ToString(), format, provider);
                Console.WriteLine(check.ToShortDateString());
            }
            catch (FormatException)
            {
                continue;
            }
        }
    }
}