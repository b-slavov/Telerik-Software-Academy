namespace ThreadSafeSingleton
{
    using System.Threading.Tasks;

    public static class Startup
    {
        public static void Main()
        {
            Log(LazyThreadSafeLogger.Instance);
        }

        public static void Log(ILogger logger)
        {
            Parallel.For(0, 6, x => logger.SaveToLog(x));
            logger.PrintLog();
        }
    }
}
