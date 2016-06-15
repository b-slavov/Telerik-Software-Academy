namespace ChainOfResponsibility
{
    internal class Purchase
    {
        public Purchase(int number, double amount)
        {
            this.Number = number;
            this.Amount = amount;
        }

        public int Number { get; set; }

        public double Amount { get; set; }
    }
}
