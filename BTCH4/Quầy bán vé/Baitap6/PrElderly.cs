using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap6
{
    class PrElderly :Price
    {

        double price = 10;
        public override double Pay(int num)
        {
            return num * price;
        }
    }
}
