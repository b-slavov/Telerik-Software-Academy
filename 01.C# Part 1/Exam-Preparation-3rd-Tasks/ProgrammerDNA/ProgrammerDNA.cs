using System;

public class ProgrammerDNA
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        string letter = Console.ReadLine();

        for (int i = 0; i < rows; i++)
        {
            int dots = 3;
            int letters = 1;
            bool change = false;
            if (i % 7 == 0)
            {
                dots = 3;
                letters = 1;
                change = false;
            }

            for (int j = 0; j < 7; j++)
            {
                Console.Write(new string('.', dots));
                Console.Write(new string('A', letters));
                Console.WriteLine(new string('.', dots));
            }

            if (change == false)
            {
                dots--;
                letters += 2;
            }
            else
            {
                dots++;
                letters -= 2;
            }

            if (dots == 0 && letters == 7)
            {
                change = true;
            }
        }
    }
}