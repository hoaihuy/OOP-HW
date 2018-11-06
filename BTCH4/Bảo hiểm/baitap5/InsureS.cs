using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    class InsureS : Insure
    {
        public InsureS() { }
        public InsureS(string name, int month, double money)
            : base(name, month, money) { }

        public override double RoseMoney()
        {
            return Money * 5 / 100;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
