using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class TienDienMoi : TienDien
    {
        int dinhmuc;

        public TienDienMoi() { }
        public TienDienMoi(string ten, string dc,
            double cu, double moi, int dinhmuc): base(ten,dc,cu,moi)
        {
            this.dinhmuc = dinhmuc;
        }

        public new void Input()
        {
            base.Input();
            Console.WriteLine(" Nhap dinh muc: ");
            dinhmuc = int.Parse(Console.ReadLine());
            
        }

        public new string Display()
        {
            return base.Display()
                 + string.Format("Dinh muc: {0}", dinhmuc);
        }

        //public new double Tinh_tien_dien()
        //{
        //    if (Cong_to_dien <= dinhmuc)
        //        base.Tinh_tien_dien();
        //    return base.Cong_to_dien * 1600;
        //}
    }
}
