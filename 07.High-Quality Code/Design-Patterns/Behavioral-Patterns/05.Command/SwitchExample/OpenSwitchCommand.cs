namespace Command.SwitchExample
{
    public class OpenSwitchCommand : ICommand
    {
        private readonly ISwitchable switchable;

        public OpenSwitchCommand(ISwitchable switchable)
        {
            this.switchable = switchable;
        }

        public void Execute()
        {
            this.switchable.PowerOff();
        }

        public void UnExecute()
        {
            this.switchable.PowerOn();
        }
    }
}
