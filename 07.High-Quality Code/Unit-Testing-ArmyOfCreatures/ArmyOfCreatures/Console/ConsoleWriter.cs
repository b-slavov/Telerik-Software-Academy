namespace ArmyOfCreatures.Console
{
    using ArmyOfCreatures.Logic;

    public class ConsoleLogger : ILogger
    {
        public void WriteLine(string line)
        {
            System.Console.WriteLine(line);
        }
    }
}
