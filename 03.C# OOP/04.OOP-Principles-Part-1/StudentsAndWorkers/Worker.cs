namespace StudentsAndWorkers
{
    using System;

    public class Worker : Human
    {
        private const uint WorkDays = 5;

        public Worker(string firstName, string lastName, decimal weekSalary, uint workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }

        public uint WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            decimal result = (this.WeekSalary / WorkDays) / this.WorkHoursPerDay;

            return Math.Round(result, 2);
        }

        public override string ToString()
        {
            return string.Format("{0, 20} - {1:C2}", this.FirstName + " " + this.LastName, this.MoneyPerHour());
        }
    }
}
