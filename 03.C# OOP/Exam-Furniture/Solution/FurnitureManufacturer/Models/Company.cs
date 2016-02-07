namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new NullReferenceException("Company name cannot be null or empty!");
                }

                if (value.Length < 5)
                {
                    throw new ArgumentException("Company name must be at least 5 symbols!");
                }
                
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                if (value == null || value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Registration number must be exactly 10 symbols!");
                }

                if (!this.ContainsOnlyDigits(value))
                {
                    throw new ArgumentException("Registration number must contain only digits!");
                }
                
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(f => f.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber, this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no", this.Furnitures.Count != 1 ? "furnitures" : "furniture"));
            foreach (var furniture in this.furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model))
            {
                result.AppendLine(furniture.ToString());
            }

            return result.ToString().TrimEnd();
        }

        private bool ContainsOnlyDigits (string str)
        {
            foreach (var ch in str)
            {
                //if (ch < '0' || ch > '9')
                if (!char.IsDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
