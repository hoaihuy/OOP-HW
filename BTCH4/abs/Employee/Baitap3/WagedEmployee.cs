using System;
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

        public override double CalcPay()
        {
            return wage * hours;
        }


        public override string DisplayStat()
        {
            return string.Format("Name: {0}; " +
                "Ngay sinh: {1}; " +
                "Dia chi: {2}; " +
                "Wage: {3}; " +
                "Hours: {4}" +
                "CalcPay: {5}",base.Name,base.SetDate(),base.SetAddress(),this.wage, this.hours,this.CalcPay());
        }
    }
}
