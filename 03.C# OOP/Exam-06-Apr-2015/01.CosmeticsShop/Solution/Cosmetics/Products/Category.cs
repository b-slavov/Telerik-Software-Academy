namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const int MinCategoryNameLength = 2;
        private const int MaxCategoryNameLength = 15;
        private const string CategoryName = "Category name";

        private string name;
        private ICollection<IProduct> products;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, CategoryName));
                Validator.CheckIfStringLengthIsValid(
                    value,
                    MaxCategoryNameLength,
                    MinCategoryNameLength,
                    string.Format(GlobalErrorMessages.InvalidStringLength, CategoryName, MinCategoryNameLength, MaxCategoryNameLength));
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            if (!this.products.Contains(cosmetics))
            {
                throw new InvalidOperationException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            var result = new StringBuilder();

            string categoryName = this.Name;
            int numberOfProducts = products.Count;
            string singularOrPlural = this.products.Count == 1 ? "product" : "products";

            result.AppendLine(string.Format("{0} category - {1} {2} in total", categoryName, numberOfProducts, singularOrPlural));
            var sortedProducts = this.products.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
            foreach (var product in sortedProducts)
            {
                result.AppendLine(product.Print());
            }

            return result.ToString().Trim();
        }
    }
}
