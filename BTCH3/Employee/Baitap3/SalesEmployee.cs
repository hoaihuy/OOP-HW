using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class SalesEmployee :SalariedEmployee
    {
        private double commission;
        private double sales;

        public SalesEmployee(string name, int year, int month, int day, double salary,
            double commission, double sales)
            :base(name,year,month,day,salary)
        {
            this.commission = commission;
            this.sales = sales;
        }
        
        public new string DisplayStat()
        {
            return base.DisplayStat()
                + string.Format("Commission: {0}; " +
                "Sales: {1}", this.commission, this.sales);
        }
    }
}
