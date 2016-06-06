namespace ThreadSafeSingleton
{
    public interface ILogger
    {
        void SaveToLog(object message);

        void PrintLog();
    }
}
