namespace Dealership.Models
{
    using System.Collections.Generic;
    using System.Text;

    using Dealership.Common;
    using Dealership.Common.Enums;
    using Dealership.Contracts;

    public abstract class Vehicle : IVehicle
    {
        private string make;
        private string model;
        private decimal price;

        public Vehicle(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
            this.Comments = new List<IComment>();
        }

        public string Make
        {
            get
            {
                return this.make;
            }

            private set
            {
                Validator.ValidateNull(value, Constants.VehicleCannotBeNull);
                ExtendetValidator.ValidateStringLength(
                    value,
                    Constants.MinMakeLength,
                    Constants.MaxMakeLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                Validator.ValidateNull(value, ExtendetConstants.ModelCannotBeNull);
                ExtendetValidator.ValidateStringLength(
                    value,
                    Constants.MinModelLength,
                    Constants.MaxModelLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                Validator.ValidateNull(value, ExtendetConstants.PriceCannotBeNull);
                Validator.ValidateDecimalRange(
                    value,
                    Constants.MinPrice,
                    Constants.MaxPrice,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }
        }

        public VehicleType Type { get; private set; }

        public abstract int Wheels { get; }

        public IList<IComment> Comments { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("  Make: {0}", this.Make));
            result.Append(string.Format("  Model: {0}", this.Model));

            return result.ToString();
        }
    }
}
