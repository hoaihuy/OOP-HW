using System;
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
        public string DisplayStat()
        {
            return base.DisplayStat()
                + string.Format("Salary: {0}", this.salary);
        }
    }
}
