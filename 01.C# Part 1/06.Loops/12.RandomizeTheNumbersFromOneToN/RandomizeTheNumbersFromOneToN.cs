using System;

class RandomizeTheNumbersFromOneToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int index = 0; index < n; index++)
        {
            array[index] = index + 1;
        }

        Random random = new Random();
        foreach (int index in array)
        {
            int randomNumber = random.Next(0, n);
            int temp = array[randomNumber];
            array[randomNumber] = array[0];
            array[0] = temp;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}