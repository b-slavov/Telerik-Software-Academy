﻿namespace Cooking
{
    using System;

    public class Cooking
    {
        private Potato potato = new Potato();

        public Cooking()
        {
        }

        public void Cook(Potato potato)
        {
            Console.WriteLine("Potato is being cooked.");
        }

        public void Cook()
        {
            if (this.potato != null)
            {
                if (this.potato.IsPeeled && !this.potato.IsRotten)
                {
                    this.Cook(this.potato);
                }
                else
                {
                    Console.WriteLine("I REFUSE to cook rotten potatoes!!!");
                }
            }
        }
    }
}