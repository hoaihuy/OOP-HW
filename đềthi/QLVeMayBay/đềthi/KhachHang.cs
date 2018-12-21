using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đềthi
{
    class KhachHang
    {
        public string HoTen { get; set; }
        public int SoDT { get; set; }

        public KhachHang() { }
        public KhachHang(string ht,int sdt)
        {
            HoTen = ht;
            this.SoDT = sdt;
        }

        public override string ToString()
        {
            return string.Format("Ho va Ten:"+ HoTen + "-"+"So Dien Thoai:"+ SoDT);
        }
    }
}
