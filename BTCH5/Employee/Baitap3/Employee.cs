using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Employee
    {
        protected string name;
        protected Address adress;
        protected Date date;

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
        public  void SetAddress(string street,string city)
        {
            adress= new Address(street,city);
        }

        public virtual string DisplayStat()
        {
            return string.Format("Name: {0}; " +
                "Ngay sinh: {1}; " +
                "Dia chi: {2}; ", this.name, this.date, this.adress);
        }





    }
}
