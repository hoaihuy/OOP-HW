using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    abstract class Employee
    {
        private string name;
        private Address adress;
        private Date date;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Employee(string name, int year, int month, int day)
        {
            this.name = name;
            date = new Date(year, month, day);
            this.adress = null;
        }
        ~Employee()
        {
            adress = null;
            date = null;
        }
        public virtual void SetAddress(string street,string city)
        {
            adress= new Address(street,city);
        }

        public virtual void SetDate(int day, int month, int year)
        {
            date = new Date(year,month,day);
        }

        public abstract double CalcPay();

        public abstract string DisplayStat();



    }
}
