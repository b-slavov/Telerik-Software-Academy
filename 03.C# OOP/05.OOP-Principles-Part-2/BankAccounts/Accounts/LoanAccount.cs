namespace Accounts
{
    using BankAccounts;

    public class LoanAccount : Account
    {
        public LoanAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, balance, interestRate)
        {
        }

        public override decimal GetInterestAmount(int months)
        {
            if (this.Customer == Customer.Individual)
            {
                if (months <= 3)
                {
                    return 0;
                }

                months -= 3;
            }
            else if (this.Customer == Customer.Company)
            {
                if (months <= 2)
                {
                    return 0;
                }

                months -= 2;
            }

            return base.GetInterestAmount(months);
        }
    }
}