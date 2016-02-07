namespace Timer
{
    using System;

    public class TimerDemo
    {
        public static void Main()
        {
            var timer = new Timer(seconds: 1, method: Print);

            timer.Start(seconds: 5);
        }

        public static void Print(string param)
        {
            Console.WriteLine("Time is {0} -> {1}", DateTime.Now.ToLongTimeString(), param);
        }
    }
}