namespace Events
{
    using System;

    public class Subscriber
    {
        private string id;

        public Subscriber(string iD, Timer pub)
        {
            this.id = iD;

            // Subscribe to the event
            pub.RaiseCustomEvent += this.HandleCustomEvent;
        }

        // Define what actions to take when the event is raised
        private void HandleCustomEvent(object sender, EventArgs args)
        {
            Console.WriteLine("Time is {0} -> At every {1} seconds i'm going to appear.", DateTime.Now.ToLongTimeString(), Timer.Delay);
        }
    }
}
