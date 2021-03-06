﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class SalariedEmployee : Employee
    {
        private double salary;
        public SalariedEmployee(string name, int year,
            int month, int day, double salary) : base(name, year, month, day)
        {
            this.salary = salary;
        }

        public double CalcPay()
        {
            return salary / 24;
        }
        public override string Tostring()
        {
            return base.Tostring()
                + string.Format("Salary: {0}", this.salary);
        }
    }
}
