using System;

namespace Lab4_P4
{
    public class Faculty : Employee
    {
        public DateTime OfficeHours { get; set; }
        public string Rank { get; set; }

        public override double CalculatedBonus()
        {
            return 1000 * 0.05 * Salary;
        }

        public override int CalculatedVacation()
        {
            var date = (DateTime.Now - DateHired).TotalDays;
            var checkDate = date > 3 * 365;
            switch (checkDate)
            {
                case true when Rank.Equals("Senior Lecturer"):
                    return 6 * 7;
                case true:
                    return 5 * 7;
                default:
                    return 4 * 7;
            }
        }
    }
}