namespace Events
{
    public class PublishEventsDemo
    {
        public static void Main()
        {
            // delay
            var publish = new Timer(seconds: 1);

            var someone = new Subscriber("Someone", publish);

            // how many seconds to continue 
            publish.Start(seconds: 5);
        }
    }
}