using System;

class BankAccount
{
    static void Main()
    {
        string firstName = "Marshall";
        string middleName = "Bruce";
        string lastName = "Mathers";
        decimal balance = 5000000.00M;
        string bankName = "ShadyBank";
        string iBAN = "BG80BNBG96611020345678";
        ulong creditCard1 = 8243063578115079;
        ulong creditCard2 = 2465773500249386;
        ulong creditCard3 = 3577854026954274;

        Console.WriteLine("Holder name: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Available amount of money: {0} euro", balance);
        Console.WriteLine("Bank name: {0}", bankName);
        Console.WriteLine("IBAN: {0}", iBAN);
        Console.WriteLine("Credit card numbers associated with this account:\n{0}\n{1}\n{2}", creditCard1, creditCard2, creditCard3);
    }
}