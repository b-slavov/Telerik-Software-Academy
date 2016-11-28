namespace AbstractFactory.Factories
{
    using System.Collections.Generic;

    using AbstractFactory.Pizzas;

    public class AlfreddosPlace : PizzaFactory
    {
        private const string Name = "Alfreddo's Pizza Palace";

        public override CheesePizza MakeCheesePizza()
        {
            var ingredients = new List<string>
                                  {
                                      "tomatoes",
                                      "white cheese",
                                      "yellow cheese",
                                      "blue cheese",
                                      "extra smelly cheese"
                                  };

            return new CheesePizza(ingredients, Name);
        }

        public override Calzone MakeCalzone()
        {
            var ingredients = new List<string> { "tomatoes", "ham", "bacon" };

            return new Calzone(ingredients, Name);
        }

        public override PepperoniPizza MakePepperoniPizza()
        {
            var ingredients = new List<string> { "tomatoes", "pepperoni", "salami" };

            return new PepperoniPizza(ingredients, Name);
        }
    }
}
