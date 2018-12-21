using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đềthi
{
    abstract class Ve
    {
        HanhKhach hk;
        public string SoHieuCB { get; set; }
        public string SanBayDen { get; set; }
        public string SanBayDi { get; set; }
        public double GiaVe { get; set; }
        
        public Ve() { }

        public Ve(string sohieucb, string sbden,
            string sbdi, double gia, HanhKhach hk)
        {
            SoHieuCB = sohieucb;
            SanBayDen = sbden;
            SanBayDi = sbdi;
            GiaVe = gia;
            this.hk = hk;
        }

        public abstract double GiamGia();

        public double TinhTien()
        {
          return GiaVe-GiaVe* GiamGia()/100;
        }

        public HanhKhach Name()
        {
            return hk;
        }

        public override string ToString()
        {
            return string.Format("Thong tin hanh khach:\n" + hk.ToString()+"\n"
                + "So hieu chuyen bay: " + SoHieuCB + " - "
                + "San bay den: " + SanBayDen + " - "
                + "San bay di: " + SanBayDi + " - "
                + "Gia ve: " + GiaVe + " - "
                + "Giam gia: " + GiamGia());
        }

    }
}
