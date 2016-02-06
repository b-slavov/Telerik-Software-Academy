using System;
using System.Text;

class VariableLenghtCoding
{
    static void Main()
    {
        var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        var encodedString = new StringBuilder();
        foreach (var item in input)
        {
            var numbers = int.Parse(item);
            encodedString.Append(Convert.ToString(numbers, 2).PadLeft(8, '0'));
        }

        int n = int.Parse(Console.ReadLine());
        char[] dictionary = new char[n + 1];
        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine();
            char symbol = line[0];
            int index = int.Parse(line.Substring(1));
            dictionary[index] = symbol;
        }

        var decoded = new StringBuilder();
        int ones = 0;
        foreach (var symbol in encodedString.ToString())
        {
            if (symbol == '1')
            {
                ones++;
            }

            else
            {
                decoded.Append(dictionary[ones]);
                ones = 0;
            }
        }

        if (ones > 0)
        {
            decoded.Append(dictionary[ones]);
        }

        Console.WriteLine(decoded);
    }
}