using System;

namespace Lab4_P4
{
    public class Staff : Employee
    {
        public string Title { get; set; }
        public override double CalculatedBonus()
        {

            return 0.06 * Salary;
        }

        public override int CalculatedVacation()
        {
            var date = (DateTime.Now - DateHired).TotalDays;
            var checkDate = date > 5 * 365;
            if (checkDate)
            {
                return 4 * 7;
            }

            return 3 * 7;
        }
    }
}