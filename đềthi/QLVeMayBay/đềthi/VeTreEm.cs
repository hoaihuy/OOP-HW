using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đềthi
{
    class VeTreEm : Ve
    {
        public VeTreEm() { }
        public VeTreEm(string sohieucb, string sbden,
            string sbdi, double gia, HanhKhach hk) : base(sohieucb, sbden, sbdi, gia,hk) { }
        public override double GiamGia()
        {
            return 25 / 100;
        }

    }
}
