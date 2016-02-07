namespace StudentsAndWorkers
{
    public abstract class Human
    {
        // fields
        private string firstName;

        private string lastName;

        // constructor
        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.ArgumentException("Invalid Name. It can't be null, empty or without letters");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new System.ArgumentException("Invalid Name. It can't be null, empty or without letters");
                }

                this.lastName = value;
            }
        }
    }
}