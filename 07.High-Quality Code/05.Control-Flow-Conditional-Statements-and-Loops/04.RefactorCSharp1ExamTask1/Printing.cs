namespace CSharp1ExamTask1
{
    using System;

    class Printing
    {
        private const decimal Realm = 500;

        static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            int paperSheets = int.Parse(Console.ReadLine());
            decimal priceOfRealm = decimal.Parse(Console.ReadLine());

            decimal savedMoney = (decimal)students * paperSheets / Realm * priceOfRealm;

            Console.WriteLine("{0:F2}", savedMoney);
        }
    }
}