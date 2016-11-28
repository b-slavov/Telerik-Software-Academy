namespace FluentInterface
{
    using System;
    using System.Linq;

    public static class Startup
    {
        public static void Main()
        {
            Enumerable.Range(0, 11)
                .Where(x => x % 2 == 0)
                .Select(x => x * x).ToList()
                .ForEach(Console.WriteLine);

            Console.WriteLine(new string('-', 60));

            var customer = new Customer();
            customer
                .FirstName("O'Shea")
                .LastName("Jackson")
                .Gender("Male")
                .Address("Los Angeles")
                .PrintToConsole();
        }
    }
}
