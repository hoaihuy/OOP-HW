using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Date
    {
        private int year;
        private int month;
        private int day;

        //public int Year
        //{
        //    get { return year; }
        //    set { year = value; }
        //}

        //public int Month
        //{
        //    get { return month; }
        //    set { month = value; }
        //}

        //public int Day
        //{
        //    get { return day; }
        //    set { day = value; }
        //}

        public Date(int year, int month, int day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
        }

        public string DisplayStat()
        {
            return string.Format("Year: {0}; " +
                "Month: {1}; " +
                "Day: {2}",this.year,this.month,this.day);
        }

    }
}
