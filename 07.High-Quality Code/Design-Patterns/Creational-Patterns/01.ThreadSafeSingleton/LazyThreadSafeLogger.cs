namespace ThreadSafeSingleton
{
    using System;
    using System.Collections.Generic;

    public sealed class LazyThreadSafeLogger : ILogger
    {
        private static readonly Lazy<LazyThreadSafeLogger> Lazy = new Lazy<LazyThreadSafeLogger>(() => new LazyThreadSafeLogger());

        private readonly List<LogEvent> events;

        private static object locker = new object();

        private LazyThreadSafeLogger()
        {
            lock(locker)
            {
                this.events = new List<LogEvent>();
            }
        }

        public static LazyThreadSafeLogger Instance
        {
            get
            {
                return Lazy.Value;
            }
        }

        public void SaveToLog(object message)
        {
            lock (locker)
            {
                this.events.Add(new LogEvent(message.ToString()));
            }
        }

        public void PrintLog()
        {
            foreach (var ev in this.events)
            {
                Console.WriteLine("Time: {0}, Event: {1}", ev.EventDate.ToShortTimeString(), ev.Message);
            }
        }
    }
}
