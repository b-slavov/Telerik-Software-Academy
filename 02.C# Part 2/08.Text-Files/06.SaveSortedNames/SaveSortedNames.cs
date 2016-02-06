using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

class SaveSortedNames
{
    static void Main()
    {
        List<string> names = new List<string>();

        StreamReader reader = new StreamReader("../../input.txt", Encoding.GetEncoding("UTF-8"));
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        using (reader)
        {
            string line = reader.ReadLine();

            while (line != null)
            {
                names.Add(line);
                line = reader.ReadLine();
            }
        }

        var sortedNames = names.OrderBy(x => x).ToList();

        StreamWriter writer = new StreamWriter("../../output.txt", false, Encoding.GetEncoding("UTF-8"));

        using (writer)
        {
            foreach (var name in sortedNames)
            {
                writer.WriteLine(name);
            }
        }

        Console.WriteLine("File \"output.txt\" created!");
    }
}