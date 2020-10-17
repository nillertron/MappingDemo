using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Employee
    {
        public  string Name { get;  }
        public double Hours { get; private set; }

        private readonly EmployeeSaver _employeeSaver;
        private readonly HourCalculator _hourCalculator;
        public Employee()
        {
            _employeeSaver = new EmployeeSaver();
            _hourCalculator = new HourCalculator();
        }

        public bool SaveEmployee()
        {
           return _employeeSaver.SaveEmployee(this);
        }
        public void SetHours(double minutes)
        {
            Hours = _hourCalculator.CalculateHoursWorked(minutes);
        }
    }
}
