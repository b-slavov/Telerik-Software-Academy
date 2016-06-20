namespace Data
{
    using Interfaces;

    public abstract class Person : ICommentable
    {
        private string firstName;

        private string lastName;

        public Person(string firstName, string lastName, string comment = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Comment = comment;
        }

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

        public string Comment { get; set; }

        public override string ToString()
        {
            return this.firstName + " " + this.lastName;
        }
    }
}
