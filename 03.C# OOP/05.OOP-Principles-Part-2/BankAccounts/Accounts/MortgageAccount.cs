namespace Accounts
{
    using BankAccounts;

    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, balance, interestRate)
        {
        }

        public override decimal GetInterestAmount(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }

                months -= 6;

                return base.GetInterestAmount(months);
            }
            else
            {
                if (months <= 12)
                {
                    return base.GetInterestAmount(months) / 2;
                }
                else
                {
                    return (base.GetInterestAmount(months) / 2) + (base.GetInterestAmount(months - 12) / 2);
                }
            }
        }
    }
}