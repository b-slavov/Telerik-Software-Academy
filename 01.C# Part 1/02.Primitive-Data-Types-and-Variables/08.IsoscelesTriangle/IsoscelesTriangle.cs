using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyright = '\u00A9';

        Console.WriteLine("   {0}\n", copyright);
        Console.WriteLine("  {0} {0}\n", copyright);
        Console.WriteLine(" {0}   {0}\n", copyright);
        Console.WriteLine("{0} {0} {0} {0}\n", copyright);
    }
}