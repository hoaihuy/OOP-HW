using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap6
{
    class PrChildren:Price
    {
        double price = 30;
        public override double Pay(int num)
        {
            return num * price;
        }
    }
}
