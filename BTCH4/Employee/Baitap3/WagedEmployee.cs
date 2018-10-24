﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class WagedEmployee :Employee
    {
        private double wage;
        private double hours;

        public WagedEmployee(string name, int year, int month, int day, double wage,
            double hours)
            :base(name,year,month,day)
        {
            this.wage = wage;
            this.hours = hours;
        }

        public override string DisplayStat()
        {
            return base.DisplayStat()
                + string.Format("Wage: {0}; " +
                "Hours: {1}", this.wage, this.hours);
        }
    }
}
