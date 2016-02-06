using System;

class AllocateArray
{
    static void Main()
    {
        int[] multipliedArray = new int[20];
        for (int i = 0; i < 20; i++)
        {
            if (i != multipliedArray.Length - 1)
            {
                Console.Write("{0} ", i * 5);
            }
            else
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}