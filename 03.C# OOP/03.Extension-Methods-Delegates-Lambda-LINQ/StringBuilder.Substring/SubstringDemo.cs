namespace StringBuilder.Substring
{
    using System;
    using System.Text;

    public class SubstringDemo
    {
        public static void Main()
        {
            var test = new StringBuilder("Testing an extension method Substring for the class StringBuilder");
            var firstTest = test.Substring(0, 37);
            var secondTest = test.Substring(38);
            Console.WriteLine(firstTest);
            Console.WriteLine(secondTest);
        }
    }
}