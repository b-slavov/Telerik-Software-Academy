namespace GSM.Tests
{
    using System;

    using GSM.Components;

    public static class GSMTest
    {
        public static void GSMShouldWork()
        {
            GSM[] mobilePhones =
            {
                new GSM("Samsung", "Galaxy S3", 600, "Ivancho", new Battery(BatteryType.Li_Ion, 300, 12), new Display(4.3f, 256000)),
                new GSM("Nokia", "Lumia 925", 850, "Pesho", new Battery(BatteryType.Li_Ion, 280, 10), new Display(4.0f, 256000))
            };

            for (int phone = 0; phone < mobilePhones.Length; phone++)
            {
                Console.WriteLine(mobilePhones[phone]);
            }

            Console.WriteLine(GSM.IPhone4S);
            Console.WriteLine(new string('*', 55));
        }
    }
}
