using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {

        StreamReader reader1 = new StreamReader("../../DMX.txt", Encoding.GetEncoding("UTF-8"));
        StreamReader reader2 = new StreamReader("../../Rick Ross.txt", Encoding.GetEncoding("UTF-8"));
        StreamWriter writer = new StreamWriter("../../Rappers.txt", false, Encoding.GetEncoding("UTF-8"));
        Console.OutputEncoding = Encoding.UTF8;

        using (writer)
        {
            using (reader1)
            {
                string line = reader1.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader1.ReadLine();
                }
            }

            using (reader2)
            {
                string line = reader2.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader2.ReadLine();
                }
            }
        }

        Console.WriteLine("File \"Rappers.txt\" created!");
    }
}