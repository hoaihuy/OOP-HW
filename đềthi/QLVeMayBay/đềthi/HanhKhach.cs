using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đềthi
{
    class HanhKhach
    {
        public string HoTen { get; set; }
        public int Tuoi { get; set; }
        public int SoDT { get; set; }

        public HanhKhach() { }
        public HanhKhach(string ht, int t, int sdt)
        {
            HoTen = ht;
            Tuoi = t;
            this.SoDT = sdt;
        }

        public override string ToString()
        {
            return string.Format("Ho va Ten:" + HoTen + " - " + "Tuoi: " + Tuoi +" - "+"So Dien Thoai:" + SoDT);
        }
    }
}
