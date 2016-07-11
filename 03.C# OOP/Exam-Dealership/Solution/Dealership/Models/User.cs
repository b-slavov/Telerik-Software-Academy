namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using Dealership.Common;
    using Dealership.Common.Enums;
    using Dealership.Contracts;

    public class User : IUser
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);
            this.Vehicles = new List<IVehicle>();
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            private set
            {
                Validator.ValidateNull(value, Constants.UserCannotBeNull);
                ExtendetValidator.ValidateStringLength(
                    value,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));
                Validator.ValidateSymbols(
                    value,
                    Constants.UsernamePattern,
                    string.Format(Constants.InvalidSymbols, "Username"));
                this.username = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                Validator.ValidateNull(value, ExtendetConstants.FirstNameCannotBeNull);
                ExtendetValidator.ValidateStringLength(
                    value,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));
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
                Validator.ValidateNull(value, ExtendetConstants.LastNameCannotBeNull);
                ExtendetValidator.ValidateStringLength(
                    value,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));
                this.lastName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            private set
            {
                Validator.ValidateNull(value, ExtendetConstants.PasswordCannotBeNull);
                ExtendetValidator.ValidateStringLength(
                    value,
                    ExtendetConstants.MinPasswordLength,
                    ExtendetConstants.MaxPasswordLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", ExtendetConstants.MinPasswordLength, ExtendetConstants.MaxPasswordLength));
                Validator.ValidateSymbols(
                    value,
                    Constants.PasswordPattern,
                    string.Format(Constants.InvalidSymbols, "Password"));
                this.password = value;
            }
        }

        public Role Role { get; private set; }

        public IList<IVehicle> Vehicles { get; private set; }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (commentToRemove.Author == this.Username)
            {
                vehicleToRemoveComment.Comments.Remove(commentToRemove);
            }
            else
            {
                throw new ArgumentException(Constants.YouAreNotTheAuthor);
            }
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(Constants.AdminCannotAddVehicles);
            }
            else if (this.Role == Role.Normal && this.Vehicles.Count == Constants.MaxVehiclesToAdd)
            {
                throw new ArgumentException(string.Format(Constants.NotAnVipUserVehiclesAdd, Constants.MaxVehiclesToAdd));
            }
            else
            {
                this.Vehicles.Add(vehicle);
            }
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.Vehicles.Remove(vehicle);
        }

        public string PrintVehicles()
        {
            var result = new StringBuilder();
            int i = 1;

            result.AppendLine(string.Format("--USER {0}--", this.Username));
            if (this.Vehicles.Count == 0)
            {
                result.AppendLine("--NO VEHICLES--");
            }
            else
            {
                foreach (var vehicle in this.Vehicles)
                {
                    result.AppendLine(i + ". " + vehicle.ToString());
                    i++;
                    if (vehicle.Comments.Count > 0)
                    {
                        result.AppendLine("    --COMMENTS--");
                        foreach (var comment in vehicle.Comments)
                        {
                            result.AppendLine("    ----------");
                            result.AppendLine(string.Format("    {0}", comment.Content));
                            result.AppendLine(string.Format("      User: {0}", comment.Author));
                            result.AppendLine("    ----------");
                        }

                        result.AppendLine("    --COMMENTS--");
                    }
                    else
                    {
                        result.AppendLine("    --NO COMMENTS--");
                    }
                }
            }

            return result.ToString().Trim();
        }

        public override string ToString()
        {
            return string.Format(ExtendetConstants.UserToString, this.Username, this.FirstName, this.LastName, this.Role);
        }
    }
}
