using System;

class PrimeNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        bool[] numbers = new bool[n + 1];
        for (int i = 2; i < Math.Sqrt(n); i++)
        {
            for (int j = i * i; j < numbers.Length; j = j + i)
            {
                numbers[j] = true;
            }
        }

        for (int i = n; i >= 0; i--)
        {
            if (numbers[i] == false)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}
