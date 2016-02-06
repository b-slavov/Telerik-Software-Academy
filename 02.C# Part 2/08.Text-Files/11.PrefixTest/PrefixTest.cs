using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../text.txt", Encoding.GetEncoding("UTF-8"));
        StreamWriter writer = new StreamWriter("../../temp.txt", false, Encoding.GetEncoding("UTF-8"));

        using (reader)
        {
            using (writer)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    line = Regex.Replace(line, @"\b(test)\w*\b", "");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        File.Delete("../../text.txt");
        File.Move("../../temp.txt", "../../text.txt");

        Console.WriteLine("File \"text.txt\" modified!");
    }
}