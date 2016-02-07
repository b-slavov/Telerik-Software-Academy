namespace Timer
{
    using System;
    using System.Threading;

    // delegate declaring
    public delegate void SimpleDelegate(string param);

    public class Timer
    {
        // fields
        private int delay;

        // constructor
        public Timer(int seconds, SimpleDelegate method)
        {
            this.Delay = seconds;
            this.SomeMethod = method;
        }

        // properties
        public SimpleDelegate SomeMethod { get; set; }

        public int Delay
        {
            get
            {
                return this.delay;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Delay can't be zero or negative.");
                }

                this.delay = value;
            }
        }

        // method that starts the timer
        public void Start(uint seconds)
        {
            DateTime end = DateTime.Now.AddMilliseconds(seconds * 1000);

            while (DateTime.Now.Second <= end.Second)
            {
                this.SomeMethod(string.Format("At every {0} seconds i'm going to appear.", this.delay));
                Thread.Sleep(this.delay * 1000);
            }
        }
    }
}
