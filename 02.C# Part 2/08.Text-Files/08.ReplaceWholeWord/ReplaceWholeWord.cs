using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8")))
        {
            using (StreamWriter writer = new StreamWriter("../../result.txt", false, Encoding.GetEncoding("UTF-8")))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine(Regex.Replace(line, @"\bstart\b", "finish"));
                    line = reader.ReadLine();
                }
            }
        }

        Console.WriteLine("File \"result.txt\" created!");
    }
}