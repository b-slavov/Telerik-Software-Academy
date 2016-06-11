namespace GSM.Tests
{
    using System;

    using GSM.Components;

    public static class CallHistoryTest
    {
        public static void CallHistoryShouldWork()
        {
            GSM testPhone = new GSM("Apple", "iPhone 5S");
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
    }
}
