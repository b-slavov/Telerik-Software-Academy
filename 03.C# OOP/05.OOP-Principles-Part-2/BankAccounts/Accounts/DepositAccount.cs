namespace Accounts
{
    using System;
    using BankAccounts;
    using Interfaces;

    public class DepositAccount : Account, IWithdrawable
    {
        public DepositAccount(Customer cust, decimal balance, decimal interestRate)
            : base(cust, balance, interestRate)
        {
        }

        public void Withdraw(decimal money)
        {
            if (this.Balance < money)
            {
                throw new ArgumentException("Your balance isn't enough.");
            }

            this.Balance -= money;
        }

        public override decimal GetInterestAmount(int months)
        {
            if (this.Balance >= 0 && this.Balance < 1000m)
            {
                return 0;
            }
            else
            {
                return base.GetInterestAmount(months);
            }
        }
    }
}