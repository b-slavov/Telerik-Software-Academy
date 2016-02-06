using System;
using System.IO;
using System.Text;

class CompareTextFiles
{
    static void Main()
    {
        int countDifferent = 0;
        int countSame = 0;

        StreamReader reader1 = new StreamReader("../../text1.txt", Encoding.GetEncoding("UTF-8"));
        StreamReader reader2 = new StreamReader("../../text2.txt", Encoding.GetEncoding("UTF-8"));
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        using (reader1)
        {
            using (reader2)
            {
                string line1 = reader1.ReadLine();
                string line2 = reader2.ReadLine();

                while ((line1 != null) && (line2 != null))
                {
                    if (line1 == line2)
                    {
                        countSame++;
                    }
                    else
                    {
                        countDifferent++;
                    }

                    line1 = reader1.ReadLine();
                    line2 = reader2.ReadLine();
                }
            }
        }

        Console.WriteLine("Same lines: " + countSame);
        Console.WriteLine("Different lines: " + countDifferent);
    }
}