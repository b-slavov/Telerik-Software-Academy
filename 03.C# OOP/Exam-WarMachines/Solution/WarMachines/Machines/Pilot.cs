namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Common;
    using WarMachines.Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> machines;

        public Pilot(string initialName)
        {
            this.Name = initialName;
            this.machines = new List<IMachine>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Pilot name cannot be null!");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.CheckIfNull(machine, "Null machine cannot be added to pilot!");

            this.machines.Add(machine);
        }

        public string Report()
        {
            var result = new StringBuilder();

            string pilotName = this.Name;
            string numberOfMachines = this.machines.Count == 0 ? "no" : this.machines.Count.ToString();
            string machineWord = this.machines.Count == 1 ? "machine" : "machines";

            result.Append(string.Format("{0} - {1} {2}", pilotName, numberOfMachines, machineWord));

            if (this.machines.Count == 0)
            {
                result.AppendLine();

                var sortedMachines = this.machines
                    .OrderBy(m => m.HealthPoints)
                    .ThenBy(m => m.Name);

                foreach (var machine in sortedMachines)
                {
                    result.AppendLine(machine.ToString());
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
