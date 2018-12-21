using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace đềthi
{
    class DSHoaDon: IEnumerable
    {
        List<HoaDon> list;
        public DSHoaDon()
        {
            list = new List<HoaDon>();
        }

        public void AddHoaDon(HoaDon hd)
        {
            list.Add(hd);
        }

        public void RemoveHoaDon(HoaDon hd)
        {
            list.Remove(hd);
        }

        public double Tongtien()
        {
            double s = 0;
            foreach (HoaDon p in list)
                s = s + p.TienPhaiTra();

            return s;
        }

        public void TimKiemSDT(string name, string sohieuchuyenbay)
        {
            foreach (HoaDon p1 in list)
                foreach (Ve p2 in p1.List())
                    if (p2.SoHieuCB == sohieuchuyenbay && p2.Name().HoTen == name)
                        Console.WriteLine(p2.Name().SoDT);

        }


        public void InHoaDon()
        {
            Console.WriteLine("Danh sach cac hoa don");
            for (int i = 0; i < list.Count(); i++)
                Console.WriteLine("Hoa don {0}: {1}", i + 1, list[i].ToString());
        }

        public IEnumerator GetEnumerator()
        {
            return list.GetEnumerator();
        }
    }
}
