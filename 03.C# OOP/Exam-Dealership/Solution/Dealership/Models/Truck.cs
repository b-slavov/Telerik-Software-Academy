namespace Dealership.Models
{
    using System.Text;

    using Dealership.Common;
    using Dealership.Contracts;
    using Dealership.Common.Enums;

    public class Truck : Vehicle, IVehicle, ITruck
    {
        private int weightCapacity;
        private int wheels = (int)VehicleType.Truck;

        public Truck(string make, string model, decimal price, int weightCapacity)
            : base(make, model, price)
        {
            this.WeightCapacity = weightCapacity;
        }

        public int WeightCapacity
        {
            get
            {
                return this.weightCapacity;
            }

            private set
            {
                Validator.ValidateNull(value, ExtendetConstants.WeightCapacityCannotBeNull);
                Validator.ValidateIntRange(
                    value,
                    Constants.MinCapacity,
                    Constants.MaxCapacity,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity));
                this.weightCapacity = value;
            }
        }

        public override int Wheels
        {
            get { return this.wheels; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(this.GetType().Name.ToString() + ":");
            result.AppendLine(base.ToString());
            result.AppendLine(string.Format("  Wheels: {0}", this.Wheels));
            result.AppendLine(string.Format("  Price: ${0}", this.Price));
            result.Append(string.Format("  Weight Capacity: {0}t", this.WeightCapacity));

            return result.ToString();
        }
    }
}
