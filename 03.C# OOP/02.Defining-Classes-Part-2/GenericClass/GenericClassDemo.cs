namespace DefiningClassesPartTwo.GenericClass
{
    using System;

    public class GenericClassDemo
    {
        public static void Main()
        {
            GenericList<int> test = new GenericList<int>(3);

            test.Add(1);
            test.Add(0);
            test.InsertAt(8, 1);
            test.Add(6);

            Console.WriteLine(GenericListMath.Min<int>(test));
            Console.WriteLine(GenericListMath.Max<int>(test));
        }
    }
}
