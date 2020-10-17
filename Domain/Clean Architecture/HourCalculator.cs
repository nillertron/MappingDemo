using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class HourCalculator
    {
        public double CalculateHoursWorked(double minutes)
        {
            return minutes / 60;
        }
    }
}
