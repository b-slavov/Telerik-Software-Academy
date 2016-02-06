using System;
using System.IO;
using System.Text;

class MaximalAreaSum
{
    static void Main()
    {
        int size = 0;
        int[,] array;

        StreamReader reader = new StreamReader("../../input.txt", Encoding.GetEncoding("UTF-8"));
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        using (reader)
        {
            size = int.Parse(reader.ReadLine());
            array = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                string[] numbers = reader.ReadLine().Split(' ');

                for (int j = 0; j < size; j++)
                {
                    array[i, j] = int.Parse(numbers[j]);
                }
            }
        }

        int max = int.MinValue;

        for (int i = 0; i < size - 1; i++)
        {
            for (int j = 0; j < size - 1; j++)
            {
                if (array[i, j] + array[i + 1, j] + array[i, j + 1] + array[i + 1, j + 1] > max)
                {
                    max = array[i, j] + array[i + 1, j] + array[i, j + 1] + array[i + 1, j + 1];
                }
            }
        }

        StreamWriter writer = new StreamWriter("../../output.txt", false, Encoding.GetEncoding("UTF-8"));

        using (writer)
        {
            writer.Write(max);
        }

        Console.WriteLine("File \"output.txt\" created!");
    }
}