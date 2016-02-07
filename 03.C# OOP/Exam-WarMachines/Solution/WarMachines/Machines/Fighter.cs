namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Fighter : Machine, IMachine, IFighter
    {
        private const int InitialHealthPoints = 200;

        public Fighter(string initialName, double initialAttackPoints, double initalDefensePoints, bool initialStealthMode)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initalDefensePoints)
        {
            this.StealthMode = initialStealthMode;
        }

        public bool StealthMode { get; private set; }

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(base.ToString());
            string stealthModeAsString = this.StealthMode ? On : Off;
            result.Append(string.Format(" *Stealth: {0}", stealthModeAsString));

            return result.ToString();
        }
    }
}
