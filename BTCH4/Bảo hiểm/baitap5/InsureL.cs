using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    class InsureL:Insure
    {
        public InsureL() { }
        public InsureL(string name, int month, double money)
            : base(name, month, money) { }

        public double PayEachMonth()
        {
            return base.Money / base.Month;
        }

        public override double RoseMoney()
        {
            return 50 * PayEachMonth() / 100;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
