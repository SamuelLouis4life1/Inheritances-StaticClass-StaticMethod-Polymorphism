using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance1.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AddicionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHours, double addicionalCharge) : base (name, hours, valuePerHours)
        {
            AddicionalCharge = addicionalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AddicionalCharge;
        }
    }
}
