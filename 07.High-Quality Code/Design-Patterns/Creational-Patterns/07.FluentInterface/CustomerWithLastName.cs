namespace FluentInterface
{
    public class CustomerWithLastName
    {
        private readonly CustomerContext context = new CustomerContext();

        public CustomerWithLastName(CustomerContext context)
        {
            this.context = context;
        }

        public Customer LastName(string lastName)
        {
            this.context.LastName = lastName;

            return new Customer(this.context);
        }
    }
}
