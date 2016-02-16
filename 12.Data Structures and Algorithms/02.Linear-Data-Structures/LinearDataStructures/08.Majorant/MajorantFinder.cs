namespace Majorant
{
    using System;
    using System.Linq;

    public class MajorantFinder
    {
        static void Main()
        {
            // Sample with no majorant
            // var numbers = new[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            // Sample with majorant
            var numbers = new[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            Console.WriteLine(string.Join(", ", numbers));
            var groupedByOccurence = numbers.GroupBy(x => x).OrderByDescending(x => x.Count()).FirstOrDefault();

            if (groupedByOccurence != null && groupedByOccurence.Count()> numbers.Count() / 2)
            {
                Console.WriteLine("Majorant --> {0} ({1} occurences)", groupedByOccurence.Key, groupedByOccurence.Count());
                return;
            }

            Console.WriteLine("No majorant in the given sequence.");
        }
    }
}