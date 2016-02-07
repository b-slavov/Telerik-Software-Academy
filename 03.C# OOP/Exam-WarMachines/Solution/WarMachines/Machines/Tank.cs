namespace WarMachines.Machines
{
    using System.Text;

    using WarMachines.Interfaces;

    public class Tank : Machine, IMachine, ITank
    {
        private const int InitialHealthPoints = 100;
        private const int AttackPointsModifier = 40;
        private const int DefensePointsModifier = 30;

        public Tank(string initialName, double initialAttackPoints, double initalDefensePoints)
            : base(initialName, InitialHealthPoints, initialAttackPoints, initalDefensePoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode { get; private set; }

        public void ToggleDefenseMode()
        {
            if (this.DefenseMode)
            {
                this.AttackPoints += AttackPointsModifier;
                this.DefensePoints -= DefensePointsModifier;
            }
            else
            {
                this.AttackPoints -= AttackPointsModifier;
                this.DefensePoints += DefensePointsModifier;
            }

            this.DefenseMode = !this.DefenseMode;
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(base.ToString());
            string defenseModeAsString = this.DefenseMode ? On : Off;
            result.Append(string.Format(" *Defense: {0}", defenseModeAsString));

            return result.ToString();
        }
    }
}
