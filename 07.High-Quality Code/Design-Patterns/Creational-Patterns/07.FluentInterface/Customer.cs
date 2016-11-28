namespace FluentInterface
{
    using System;

    public class Customer
    {
        private readonly CustomerContext context;

        public Customer()
        {
            this.context = new CustomerContext();
        }

        public Customer(CustomerContext context)
        {
            this.context = context;
        }

        public CustomerWithLastName FirstName(string firstName)
        {
            this.context.FirstName = firstName;

            return new CustomerWithLastName(this.context);
        }

        public Customer Gender(string gender)
        {
            this.context.Gender = gender;

            return this;
        }

        public Customer Address(string address)
        {
            this.context.Address = address;

            return this;
        }

        public void PrintToConsole()
        {
            Console.WriteLine($"First name: {this.context.FirstName}");
            Console.WriteLine($"Last name: {this.context.LastName}");
            Console.WriteLine($"Gender: {this.context.Gender}");
            Console.WriteLine($"Address: {this.context.Address}");
        }
    }
}
