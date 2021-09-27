using System;

namespace Lab4_P4
{
    public abstract class Employee : Person
    {
        public string Department { get; set; }
        public double Salary { get; set; }
        public DateTime DateHired { get; set; }
        
        public abstract double CalculatedBonus();
        public abstract int CalculatedVacation ();
    }
}