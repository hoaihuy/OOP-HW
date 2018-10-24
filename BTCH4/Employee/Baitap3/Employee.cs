using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Employee
    {
        private string name=" ";
        private Address adress=null;
        private Date date;

        public Employee(string name, int year, int month, int day)
        {
            this.name = name;
            date = new Date(year, month, day);
        }
        ~Employee()
        {
            adress = null;
            date = null;
        }
        public void SetAddress(string street, string city)
        {
            adress= new Address(street, city);
        }

        public virtual string DisplayStat()
        {
            return string.Format("Name: {0}; " +
                "Ngay sinh: {1}; " +
                "Dia chi: {2}; ",this.name,
                this.date.DisplayStat(),
                this.adress.DisplayStat());
        }



    }
}
