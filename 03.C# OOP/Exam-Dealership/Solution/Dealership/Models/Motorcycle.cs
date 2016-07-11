namespace Dealership.Models
{
    using System.Text;

    using Dealership.Common;
    using Dealership.Contracts;
    using Dealership.Common.Enums;

    public class Motorcycle : Vehicle, IVehicle, IMotorcycle
    {
        private string category;
        private int wheels = (int)VehicleType.Motorcycle;

        public Motorcycle(string make, string model, decimal price, string category)
            : base(make, model, price)
        {
            this.Category = category;
        }

        public string Category
        {
            get
            {
                return this.category;
            }

            private set
            {
                Validator.ValidateNull(value, ExtendetConstants.CategoryCannotBeNull);
                ExtendetValidator.ValidateStringLength(
                    value,
                    Constants.MinCategoryLength,
                    Constants.MaxCategoryLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
                this.category = value;
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
            result.Append(string.Format("  Category: {0}", this.Category));

            return result.ToString();
        }
    }
}
