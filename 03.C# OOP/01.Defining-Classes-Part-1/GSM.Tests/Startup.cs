namespace GSM.Tests
{
    using System;
    using Components;

    public class Startup
    {
        public static void Main()
        {
            Console.WindowHeight = 50;

            Console.WriteLine("\nEXERCISES FROM 1 to 7\n");
            TestGSMDevice();

            Console.WriteLine("\nEXERCISES FROM 8 to 12\n");
            TestCallHistory();
        }

        private static void TestCallHistory()
        {
            GSMDevice testPhone = new GSMDevice("Apple", "iPhone 5S");
            testPhone.AddCall(DateTime.Now, "0889804123", 120);
            testPhone.AddCall(new DateTime(2014, 2, 27, 13, 10, 12), "0888888888", 110);
            testPhone.AddCall(new DateTime(2014, 03, 12, 10, 30, 00), "0877234888", 150);

            Console.WriteLine("Call history:");
            Console.WriteLine(testPhone.CallHistory);
            Console.WriteLine("Total price: {0}\n", testPhone.GetTotalPrice());

            Console.WriteLine("Call history without the longest call:");
            testPhone.RemoveLongestCall();
            Console.WriteLine(testPhone.CallHistory);
            Console.WriteLine("Total price: {0}\n", testPhone.GetTotalPrice());

            testPhone.ClearCallHistory();
            Console.WriteLine(testPhone.CallHistory);
        }

        private static void TestGSMDevice()
        {
            GSMDevice[] mobilePhones = 
            {
                new GSMDevice("Samsung", "Galaxy S3", 600, "Ivancho", new Battery(BatteryType.Li_Ion, 300, 12), new Display(4.3f, 256000)),
                new GSMDevice("Nokia", "Lumia 925", 850, "Pesho", new Battery(BatteryType.Li_Ion, 280, 10), new Display(4.0f, 256000))
            };

            for (int phone = 0; phone < mobilePhones.Length; phone++)
            {
                Console.WriteLine(mobilePhones[phone]);
            }

            Console.WriteLine(GSMDevice.IPhone4S);
            Console.WriteLine(new string('*', 55));
        }
    }
}
