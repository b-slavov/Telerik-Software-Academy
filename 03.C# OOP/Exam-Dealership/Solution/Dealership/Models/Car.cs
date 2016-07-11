namespace Dealership.Models
{
    using System.Text;

    using Dealership.Common;
    using Dealership.Common.Enums;
    using Dealership.Contracts;

    public class Car : Vehicle, IVehicle, ICar
    {
        private int seats;
        private int wheels = (int)VehicleType.Car;

        public Car(string make, string model, decimal price, int seats)
            : base(make, model, price)
        {
            this.Seats = seats;
        }

        public int Seats
        {
            get
            {
                return this.seats;
            }

            private set
            {
                Validator.ValidateNull(value, ExtendetConstants.SeatsCannotBeNull);
                Validator.ValidateIntRange(
                    value,
                    Constants.MinSeats,
                    Constants.MaxSeats,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats", Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
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
            result.Append(string.Format("  Seats: {0}", this.Seats));

            return result.ToString();
        }
    }
}
