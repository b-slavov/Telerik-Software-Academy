namespace Iterator.ClearImplementation
{
    public interface IIterator
    {
        void Next();

        bool IsDone();

        object CurrentItem();
    }
}
