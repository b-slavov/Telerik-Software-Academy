using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ExtractTextFromXML
{
    public static string StripTagsRegex(string source)
    {
        return Regex.Replace(source, "<.*?>", string.Empty);
    }

    static void Main()
    {
        StreamReader reader = new StreamReader("../../student.xml", Encoding.GetEncoding("UTF-8"));
        Console.OutputEncoding = Encoding.UTF8;

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                Console.WriteLine(StripTagsRegex(line));
                line = reader.ReadLine();
            }
        }
    }
}