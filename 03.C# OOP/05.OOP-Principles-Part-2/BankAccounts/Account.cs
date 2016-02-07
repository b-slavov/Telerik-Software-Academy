namespace BankAccounts
{
    using Interfaces;

    public abstract class Account : IDepositable
    {
        private const int Percent = 100;

        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer cust, decimal balance, decimal interestRate)
        {
            this.Customer = cust;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            protected set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new System.ArgumentException("interest rate can't be negative");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal GetInterestAmount(int months)
        {
            if (months < 0)
            {
                months = 0;
            }

            return months * (this.interestRate / Percent) * this.balance;
        }

        public void Deposit(decimal money)
        {
            if (money <= 0)
            {
                throw new System.ArgumentException("Invalid amount of money.");
            }

            this.balance += money;
        }
    }
}