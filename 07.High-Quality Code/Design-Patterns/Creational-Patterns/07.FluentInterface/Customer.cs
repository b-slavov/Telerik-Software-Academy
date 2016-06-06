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
            Console.WriteLine("first name: {0} \nlast name: {1} \ngender: {2} \naddress: {3}", this.context.FirstName, this.context.LastName, this.context.Gender, this.context.Address);
        }
    }
}
