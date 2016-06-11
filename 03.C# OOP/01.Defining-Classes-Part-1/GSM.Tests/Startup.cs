namespace GSM.Tests
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Console.WindowHeight = 50;

            Console.WriteLine("Exercises from 1 to 7\n");
            GSMTest.GSMShouldWork();

            Console.WriteLine("\nExercises from 8 to 12\n");
            CallHistoryTest.CallHistoryShouldWork();
        }
    }
}
