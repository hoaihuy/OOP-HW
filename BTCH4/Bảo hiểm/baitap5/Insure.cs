using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    abstract class Insure
    {
        public string Buyer { get; set; }
        public int Month { get; set; }
        public double Money { get; set; }

        public Insure() { }
        public Insure(string buyer,int month,double money)
        {
            this.Buyer = buyer;
            this.Month = month;
            this.Money = money;
        }


        public abstract double RoseMoney();

        public override string ToString()
        {
            return string.Format("Buyer: {0} -- Month: {1} -- Money: {2}", Buyer, Month, Money);
        }
    }
}
