namespace Cosmetics.Products
{
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        private const int MinProductNameLength = 3;
        private const int MaxProductNameLength = 10;
        private const int MinBrandLength = 2;
        private const int MaxBrandLength = 10;
        private const string ProductName = "Product name";
        private const string ProductBrand = "Product brand";

        private string name;
        private string brand;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductName));
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxProductNameLength,
                    MinProductNameLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, "Product name", MinProductNameLength, MaxProductNameLength));
                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductBrand));
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxBrandLength,
                    MinBrandLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, "Product brand", MinBrandLength, MaxBrandLength));
                this.brand = value;
            }
        }

        public decimal Price { get; protected set; }

        public GenderType Gender { get; private set; }

        public virtual string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(string.Format("- {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format("  * Price: ${0}", this.Price));
            result.Append(string.Format("  * For gender: {0}", this.Gender));

            return result.ToString();
        }
    }
}
