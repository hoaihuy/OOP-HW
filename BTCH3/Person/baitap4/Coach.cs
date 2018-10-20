using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    class Coach : Person
    {
        private int year;

        public int Year
        {
            get { return this.year; }
            set { this.year = value; }
        }

        public Coach() { }
        public Coach(string name, int age, string nationality,int year)
            :base(name,age,nationality)
        {
            this.year = year;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Year: "+this.year);
        }
    }
}
