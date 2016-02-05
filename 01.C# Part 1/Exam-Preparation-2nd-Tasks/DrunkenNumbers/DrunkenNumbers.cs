using System;

class DrunkenNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long m = 0;
        long v = 0;

        for (int i = 0; i < n; i++)
        {
            long roundInfo = long.Parse(Console.ReadLine());
            if (roundInfo < 0)
            {
                roundInfo = -roundInfo;
            }
            int digits = 0;
            long tempRoundInfo = roundInfo;

            while (tempRoundInfo > 0)
            {
                tempRoundInfo /= 10;
                digits++;
            }

            if (digits % 2 == 0)
            {
                for (int j = 0; j < digits / 2; j++)
                {
                    v += (roundInfo % 10);
                    roundInfo /= 10;
                }
                for (int j = 0; j < digits / 2; j++)
                {
                    m += (roundInfo % 10);
                    roundInfo /= 10;
                }
            }
            else
            {
                for (int j = 0; j < digits / 2; j++)
                {
                    v += (roundInfo % 10);
                    roundInfo /= 10;
                }

                long middle = roundInfo % 10;
                v += middle;
                m += middle;
                roundInfo /= 10;

                for (int j = 0; j < digits / 2; j++)
                {
                    m += (roundInfo % 10);
                    roundInfo /= 10;
                }
            }
        }

        if (m > v)
        {
            Console.WriteLine("M {0}", m - v);
        }
        else if (m < v)
        {
            Console.WriteLine("V {0}", v - m);
        }
        else
        {
            Console.WriteLine("No {0}", m + v);
        }
    }
}