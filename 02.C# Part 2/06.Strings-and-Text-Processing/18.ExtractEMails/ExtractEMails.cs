using System;
using System.Text.RegularExpressions;

class ExtractEMails
{
    static public string[] ExtractMails(string str)
    {
        string RegexPattern = @"\b[A-Z0-9._-]+@[A-Z0-9][A-Z0-9.-]{0,61}[A-Z0-9]\.[A-Z.]{2,6}\b";

        MatchCollection matches = Regex.Matches(str, RegexPattern, RegexOptions.IgnoreCase);

        string[] MatchList = new string[matches.Count];

        int counter = 0;
        foreach (Match match in matches)
        {
            MatchList[counter] = match.ToString();
            counter++;
        }

        return MatchList;
    }

    static void Main()
    {
        Console.WriteLine("Enter text: ");
        string[] emails = ExtractMails(Console.ReadLine());

        foreach (string mail in emails)
        {
            Console.WriteLine(mail);
        }
    }
}