using System;

class EnterNumbers
{
    static int ReadNumber(int start, int end)
    {
        int value = int.Parse(Console.ReadLine());

        if ((value < start) || (value > end))
        {
            throw new Exception("Invalid number!");
        }

        return value;
    }

    static void Main()
    {
        int[] values = new int[10];
        int min = 1;
        int max = 100;

        try
        {
            values[0] = ReadNumber(min, max);
            for (int i = 1; i < values.Length; i++)
            {
                min = values[i - 1];
                values[i] = ReadNumber(min, max);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Exception");
        }
    }
}
