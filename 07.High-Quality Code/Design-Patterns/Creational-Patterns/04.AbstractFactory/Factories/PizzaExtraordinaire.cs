namespace AbstractFactory.Factories
{
    using System.Collections.Generic;

    using AbstractFactory.Pizzas;

    public class PizzaExtraordinaire : PizzaFactory
    {
        private const string Name = "Pizza Extraordinaire";

        public override CheesePizza MakeCheesePizza()
        {
            var ingredients = new List<string> { "rotten tomatoes", "grey cheese", "green cheese" };

            return new CheesePizza(ingredients, Name);
        }

        public override Calzone MakeCalzone()
        {
            var ingredients = new List<string> { "rotten tomatoes", "greasy ham" };

            return new Calzone(ingredients, Name);
        }

        public override PepperoniPizza MakePepperoniPizza()
        {
            var ingredients = new List<string> { "old salami", "green tomatoes" };

            return new PepperoniPizza(ingredients, Name);
        }
    }
}
