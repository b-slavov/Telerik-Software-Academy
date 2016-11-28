namespace AbstractFactory.Pizzas
{
    using System.Collections.Generic;

    public class CheesePizza : Pizza
    {
        private readonly string madeBy;

        public CheesePizza(IEnumerable<string> ingredients, string madeBy)
            : base(ingredients)
        {
            this.madeBy = madeBy;
        }

        protected override string Name
        {
            get
            {
                return $"Cheese pizza, made by {this.madeBy}";
            }
        }
    }
}
