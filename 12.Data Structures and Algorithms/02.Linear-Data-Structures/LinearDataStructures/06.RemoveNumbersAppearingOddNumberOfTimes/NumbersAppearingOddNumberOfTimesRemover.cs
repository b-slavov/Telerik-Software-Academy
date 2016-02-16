namespace RemoveNumbersAppearingOddNumberOfTimes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNumbersAppearingOddNumberOfTimes
    {
        static void Main()
        {
            var numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            var filteredNumbersGroups = numbers.GroupBy(x => x).Where(x => x.Count() % 2 == 0);

            var filteredNumbers = new List<int>();

            foreach (var group in filteredNumbersGroups)
            {
                filteredNumbers.AddRange(group);
            }

            Console.WriteLine("Initial sequence: " + string.Join(", ", numbers));
            Console.WriteLine("Numbers occuring even number of times: " + string.Join(", ", filteredNumbers));
        }
    }
}