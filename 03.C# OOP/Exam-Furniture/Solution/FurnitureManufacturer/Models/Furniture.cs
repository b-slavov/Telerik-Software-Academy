namespace FurnitureManufacturer.Models
{
    using System;
    
    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private decimal price;
        private decimal height;

        public virtual string Model
        {
            get
            {
                return this.model;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new AggregateException("Model cannot be empty or null!");
                }

                if (value.Length < 3)
                {
                    throw new AggregateException("Model cannot be with less than 3 symbols!");
                }

                this.model = value;
            }
        }

        public virtual string Material
        {
            get
            {
                return this.MaterialType.ToString();
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new AggregateException("Price cannot be less or equal to $0.00!");
                }

                this.price = value;
            }
        }

        public virtual decimal Height
        {
            get
            { 
                return this.height;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new AggregateException("Height cannot be less or equal to 0.00m!");
                }

                this.height = value;
            }
        }

        protected MaterialType MaterialType { get; set; }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
