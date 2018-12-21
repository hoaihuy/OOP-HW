using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đềthi
{
    class VeCaoTuoi : Ve
    {
        public VeCaoTuoi() { }
        public VeCaoTuoi(string sohieucb, string sbden,
            string sbdi, double gia, HanhKhach hk) : base(sohieucb, sbden, sbdi, gia, hk) { }
        public override double GiamGia()
        {
            return 30;
        }


    }
}
