namespace DefiningClassesPartTwo.GenericClass
{
    using System;

    public class GenericListMath
    {
        public static T Min<T>(GenericList<T> list)
            where T : IComparable<T>
        {
            T minValue = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (minValue.CompareTo(list[i]) > 0)
                {
                    minValue = list[i];
                }
            }

            return minValue;
        }

        public static T Max<T>(GenericList<T> list)
            where T : IComparable<T>
        {
            T maxValue = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (maxValue.CompareTo(list[i]) < 0)
                {
                    maxValue = list[i];
                }
            }

            return maxValue;
        }
    }
}
