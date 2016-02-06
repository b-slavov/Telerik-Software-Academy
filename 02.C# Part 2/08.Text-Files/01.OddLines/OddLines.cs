using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {

        StreamReader reader = new StreamReader("../../Eminem.txt", Encoding.GetEncoding("UTF-8"));
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        using (reader)
        {
            int counter = 0;
            string line = reader.ReadLine();

            while (line != null)
            {
                if (counter % 2 == 1)
                {
                    Console.WriteLine(line);
                }

                line = reader.ReadLine();
                counter++;
            }
        }
    }
}