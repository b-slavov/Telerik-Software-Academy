namespace Events
{
    using System;
    using System.Threading;

    public class Timer : EventArgs
    {
        // fields
        private static int delay;

        // constructor 
        public Timer(int seconds)
        {
            Delay = seconds;
        }

        // declare the event using EventHandler<T>
        public event EventHandler RaiseCustomEvent;

        // property
        public static int Delay
        {
            get
            {
                return delay;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Delay can't be zero or negative.");
                }

                delay = value;
            }
        }

        // method that start testing
        public void Start(uint seconds)
        {
            DateTime end = DateTime.Now.AddMilliseconds(seconds * 1000);

            while (DateTime.Now.Second <= end.Second)
            {
                this.OnRaiseCustomEvent();

                Thread.Sleep(Delay * 1000);
            }
        }

        // method that raises the event
        protected void OnRaiseCustomEvent()
        {
            EventHandler handler = this.RaiseCustomEvent;

            if (handler != null)
            {
                handler(this, null);
            }
        }
    }
}
