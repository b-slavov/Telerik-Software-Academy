using System;

class ASCIITable
{
    static void Main()
    {
        Console.WriteLine("ASCII Table:\n");
        for (int counter = 0; counter < 256; counter++)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("{0} -> {1}", counter, (char)counter);
        }

    }
}