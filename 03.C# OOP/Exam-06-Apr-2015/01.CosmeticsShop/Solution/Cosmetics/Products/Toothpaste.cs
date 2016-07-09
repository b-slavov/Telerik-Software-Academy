namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private const int MinIngredientsNameLength = 4;
        private const int MaxIngredientsNameLength = 12;

        private readonly ICollection<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ValidateIngredientsNameLength(ingredients);
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); }
        }

        private void ValidateIngredientsNameLength(IList<string> ingredients)
        {
            if (ingredients.Any(i => i.Length < MinIngredientsNameLength || i.Length > MaxIngredientsNameLength))
            {
                throw new IndexOutOfRangeException(
                    string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", MinIngredientsNameLength, MaxIngredientsNameLength));
            }
        }

        public override string Print()
        {
            var result = new StringBuilder();

            result.AppendLine(base.Print());
            result.Append(string.Format("  * Ingredients: {0}", this.Ingredients));

            return result.ToString();
        }
    }
}
