using System;
using System.IO;
using System.Text;

class LineNumbers
{
    static void Main()
    {

        StreamReader reader = new StreamReader("../../The 50 Greatest Rappers Of All Time.txt", Encoding.GetEncoding("UTF-8"));
        StreamWriter writer = new StreamWriter("../../With Line Numbers.txt", false, Encoding.GetEncoding("UTF-8"));
        Console.OutputEncoding = Encoding.UTF8;

        using (reader)
        {
            using (writer)
            {
                int cnt = 1;
                string line = reader.ReadLine();

                while (line != null)
                {
                    writer.WriteLine("{0}. {1}", cnt, line);
                    line = reader.ReadLine();
                    cnt++;
                }
            }
        }

        Console.WriteLine("File \"With Line Numbers.txt\" created!");
    }
}