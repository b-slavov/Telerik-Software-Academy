﻿namespace Observer.ClearImplementation
{
    using System;

    public class SorrosInvestor : IInvestor
    {
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified Sorros of {0}'s " + "change to {1:C}", stock.Symbol, stock.Price);
        }
    }
}
