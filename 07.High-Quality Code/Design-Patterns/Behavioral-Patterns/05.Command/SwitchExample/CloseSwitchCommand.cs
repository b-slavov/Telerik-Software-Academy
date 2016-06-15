namespace Command.SwitchExample
{
    public class CloseSwitchCommand : ICommand
    {
        private readonly ISwitchable switchable;

        public CloseSwitchCommand(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Execute()
        {
            this.switchable.PowerOn();
        }

        public void UnExecute()
        {
            this.switchable.PowerOff();
        }
    }
}
