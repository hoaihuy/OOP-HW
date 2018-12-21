using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đềthi
{
    class HoaDon
    {
        List<Ve> listve;
        KhachHang kh;
        
        public HoaDon() { listve = new List<Ve>(); }

        public HoaDon(KhachHang kh)
        {
            listve = new List<Ve>();
            this.kh = kh;
        }

        ~HoaDon() {
            kh = null;
            listve = null;
        }

        public List<Ve> List()
        {
            return listve;
        }

        public void AddVe(Ve v)
        {
            listve.Add(v);
        }

        public void RemoveVe(Ve v)
        {
            listve.Remove(v);
        }

        public double TienPhaiTra()
        {
            double s = 0;
            foreach (Ve p in listve)
                s = s + p.TinhTien();
            return s;
        }

        public override string ToString()
        {
           return string.Format("Khach hang:"+this.kh.HoTen);
        }

        public void InHoaDon()
        {
            Console.WriteLine("Khach hang: ", kh.ToString());
            for (int i = 0; i < listve.Count(); i++)
                Console.WriteLine("Ve {0}: {1}", i + 1, listve[i].ToString());
        }
    }
}
