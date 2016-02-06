using System;
using System.IO;
using System.Text;

class DeleteOddLines
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
                int counter = 1;

                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        writer.WriteLine(line);
                    }
                    line = reader.ReadLine();
                    counter++;
                }
            }
        }

        File.Delete("../../text.txt");
        File.Move("../../temp.txt", "../../text.txt");

        Console.WriteLine("File \"text.txt\" modified!");
    }
}