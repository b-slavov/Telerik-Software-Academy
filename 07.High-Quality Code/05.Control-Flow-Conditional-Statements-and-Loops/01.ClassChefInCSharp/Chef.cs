namespace Cooking
{
    using System;

    public class Chef
    {
        public void Cook()
        {
            Bowl bowl = new Bowl();
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();
            this.GetBowl();

            this.Peel(potato);
            this.Peel(carrot);

            this.Cut(potato);
            this.Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
        return new Bowl();
        }

        private Potato GetPotato()
        {
        return new Potato();
        }

        private Carrot GetCarrot()
        {
        return new Carrot();
        }

        private void Cut(Vegetable vegetable)
        {
            Console.WriteLine("{0} is cut.", vegetable);
        }

        private void Peel(Vegetable vegetable)
        {
            Console.WriteLine("{0} is peeled.", vegetable);
        }
    }
}