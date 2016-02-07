namespace BankAccounts
{
    using System;
    using System.Globalization;
    using System.Threading;
    using Accounts;

    public class BankDemo
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            DepositAccount dep = new DepositAccount(
                cust: Customer.Company,
                balance: 200,
                interestRate: 20);

            Console.WriteLine("Deposit account's Interest Amount: {0}", dep.GetInterestAmount(months: 6));

            // when balance is more than 1000
            dep.Deposit(900m);
            Console.WriteLine("Deposit account's Interest Amount: {0}\n", dep.GetInterestAmount(months: 6));

            // individual
            LoanAccount loanIndividual = new LoanAccount(
                cust: Customer.Individual,
                balance: 100,
                interestRate: 15);

            Console.WriteLine("Loan individual account's Interest Amount: {0}", loanIndividual.GetInterestAmount(months: 3));
            Console.WriteLine("Loan individual account's Interest Amount: {0}\n", loanIndividual.GetInterestAmount(months: 5));

            // company
            LoanAccount loanCompany = new LoanAccount(
                cust: Customer.Company,
                balance: 100,
                interestRate: 15);

            Console.WriteLine("Loan company account's Interest Amount: {0}", loanCompany.GetInterestAmount(months: 2));
            Console.WriteLine("Loan company account's Interest Amount: {0}\n", loanCompany.GetInterestAmount(months: 5));

            // individual
            MortgageAccount mortIndividual = new MortgageAccount(
                cust: Customer.Individual,
                balance: 350,
                interestRate: 5);

            Console.WriteLine("Mortgage individual account's Interest Amount: {0}", mortIndividual.GetInterestAmount(months: 7));
            Console.WriteLine("Mortgage individual account's Interest Amount: {0}\n", mortIndividual.GetInterestAmount(months: 8));

            // company
            MortgageAccount mortCompany = new MortgageAccount(
                cust: Customer.Company,
                balance: 20000,
                interestRate: 10);

            Console.WriteLine("Mortgage company account's Interest Amount: {0}", mortCompany.GetInterestAmount(months: 10));
            Console.WriteLine("Mortgage company account's Interest Amount: {0}\n", mortCompany.GetInterestAmount(months: 24));
        }
    }
}