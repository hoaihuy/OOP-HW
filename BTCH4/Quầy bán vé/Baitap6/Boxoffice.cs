using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap6
{
    class BoxOffice
    {
        Price Pr;
        ~ BoxOffice() { Pr = null; }
        public int numpeople { get; set; }


        public double Pay_Children(int num)
        {
            return Pr.Pay(numpeople);

        }
        public double Pay_Audlt(int num)
        {
            return Pr.Pay(numpeople);
        }
        public double Pay_Elderly(int num)
        {
            return Pr.Pay(numpeople);
        }
    }
}
