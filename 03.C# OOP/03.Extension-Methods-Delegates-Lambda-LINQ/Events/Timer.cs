namespace Events
{
    using System;
    using System.Threading;

    public class Timer : EventArgs
    {
        private static int delay;

        public Timer(int seconds)
        {
            Delay = seconds;
        }

        // Declare the event using EventHandler<T>
        public event EventHandler RaiseCustomEvent;

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

        public void Start(uint seconds)
        {
            var end = DateTime.Now.AddMilliseconds(seconds * 1000);

            while (DateTime.Now.Second <= end.Second)
            {
                this.OnRaiseCustomEvent();

                Thread.Sleep(Delay * 1000);
            }
        }

        // Method that raises the event
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
