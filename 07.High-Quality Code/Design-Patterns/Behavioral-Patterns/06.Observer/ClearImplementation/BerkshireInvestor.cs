namespace Observer.ClearImplementation
{
    using System;

    public class BerkshireInvestor : IInvestor
    {
        public void Update(Stock stock)
        {
            Console.WriteLine("Notified Berkshire of {0}'s " + "change to {1:C}", stock.Symbol, stock.Price);
        }
    }
}
