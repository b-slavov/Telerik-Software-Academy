namespace Strategy
{
    public class DoSomethingImportant
    {
        private readonly ILogger logger;

        public DoSomethingImportant(ILogger logger)
        {
            this.logger = logger;
        }

        // Poor man's dependency inversion
        public DoSomethingImportant()
            : this(new ConsoleLogger())
        {
        }

        // Null check with "?"
        // The other way is with NoLogger class
        public void DoTheJob()
        {
            this.logger?.Log("Starting work...");
            this.logger?.Log("Working...");
            this.logger?.Log("Work done.");
        }
    }
}
