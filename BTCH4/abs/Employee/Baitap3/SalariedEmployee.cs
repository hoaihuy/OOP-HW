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

        public override double CalcPay()
        {
            return salary / 24;
        }
        public override string DisplayStat()
        {
            return string.Format("Name: {0}; " +
                "Ngay sinh: {1}; " +
                "Dia chi: {2}; " +
                "Salary: {3}" +
                 "CalcPay: {4}", base.Name, base.SetDate(), base.SetAddress(), this.salary,this.CalcPay());
        }
    }
}
