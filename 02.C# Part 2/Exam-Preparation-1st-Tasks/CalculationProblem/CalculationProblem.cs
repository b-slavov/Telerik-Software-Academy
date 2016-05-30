using System;
using System.Linq;

class Startup
{
    static int MeowToDec(string meow)
    {
        int result = 0;

        foreach (char digit in meow)
        {
            result = (digit - 'a') + result * 23;
        }

        return result;
    }

    static string DecToMeow(int dec)
    {
        var result = string.Empty;

        do
        {
            char digit = (char)('a' + (dec % 23));
            result = digit + result;
            dec /= 23;

        } while (dec > 0);

        return result;
    }

    static void Main()
    {
        var sum = Console.ReadLine().Split(' ').Select(MeowToDec).Sum();

        var answer = DecToMeow(sum) + " = " + sum;

        Console.WriteLine(answer);
    }
}
