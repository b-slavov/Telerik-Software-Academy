namespace Strategy
{
    // Null object
    public class NoLogger : ILogger
    {
        public void Log(string message)
        {
        }
    }
}
