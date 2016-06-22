namespace _02.StudentsAndWorkers.Models
{
    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string FirstName { get; set; }

        public override string LastName { get; set; }

        public decimal WeekSalary { get; set; }

        public double WorkHoursPerDay { get; set; }

        public string MoneyPerHour()
        {
            decimal daySalary = this.WeekSalary / 5;

            return string.Format("{0:C2}", daySalary / (decimal)this.WorkHoursPerDay);
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} => Week Salary: " + string.Format("{0:C2} | ", this.WeekSalary) + $"Money per hour: {this.MoneyPerHour()}";
        }
    }
}
