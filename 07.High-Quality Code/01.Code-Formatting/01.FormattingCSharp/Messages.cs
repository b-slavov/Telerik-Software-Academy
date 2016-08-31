namespace FormattingCSharp
{
    using System;
    using System.Text;

    public static class Messages
    {
        public static StringBuilder Output { get; set; }

        public static void EventAdded()
        {
            Output.AppendLine("Event added");
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                Output.AppendLine(string.Format("{0} events deleted", x));
            }
        }

        public static void NoEventsFound()
        {
            Output.AppendLine("No events found");
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                Output.AppendLine(eventToPrint.ToString());
            }
        }

        internal static void PrintEvent(object eventToShow)
        {
            throw new NotImplementedException();
        }
    }
}
