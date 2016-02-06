using System;

class SortByStringLength
{
    static void Main()
    {
        string[] array = { "Rick Ross", "Eminem", "DMX", "Spens", "2Pac" };

        Array.Sort(array, (x, y) => (x.Length).CompareTo(y.Length));
        foreach (string element in array)
        {
            Console.WriteLine(element);
        }
    }
}