using System;
using System.Globalization;
using System.Threading;

class Garden
{
    static void Main()
    {
        int tomatoSeedsAmound = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        int cucumberSeedsAmound = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        int potatoSeedsAmound = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        int carrotSeedsAmound = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        int cabbageSeedsAmound = int.Parse(Console.ReadLine());
        int cabbageArea = int.Parse(Console.ReadLine());
        int beansSeedsAmound = int.Parse(Console.ReadLine());

        decimal tomatoSeedPrice = 0.5M;
        decimal cucumberSeedPrice = 0.4M;
        decimal potatoSeedPrice = 0.25M;
        decimal carrotSeedPrice = 0.6M;
        decimal cabbageSeedPrice = 0.3M;
        decimal beansSeedPrice = 0.4M;

        int totalArea = 250;

        decimal totalCosts = tomatoSeedsAmound * tomatoSeedPrice + cucumberSeedsAmound * cucumberSeedPrice + potatoSeedsAmound * potatoSeedPrice + carrotSeedsAmound * carrotSeedPrice + cabbageSeedsAmound * cabbageSeedPrice + beansSeedsAmound * beansSeedPrice;
        int beansArea = totalArea - tomatoArea - cucumberArea - potatoArea - carrotArea - cabbageArea;

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Total costs: {0:F2}", totalCosts);

        if (beansArea > 0)
        {
            Console.WriteLine("Beans area: " + beansArea);
        }
        else if (beansArea < 0)
        {
            Console.WriteLine("Insufficient area");
        }
        else
        {
            Console.WriteLine("No area for beans");
        }
    }
}