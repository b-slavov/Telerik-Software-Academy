using System;

class TheHorror
{
    static void Main()
    {
        string text = Console.ReadLine();
        int counter = 0;
        int evenCounter = 0;
        int sum = 0;

        foreach (char symbol in text)
        {
            if (counter % 2 == 0)
            {
                if (Char.IsDigit(symbol))
                {
                    evenCounter++;
                    sum += symbol - '0';
                }
            }
            counter++;
        }
        Console.WriteLine(evenCounter + " " + sum);
    }
}