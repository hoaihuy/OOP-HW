using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class MayLaser : May
    {
        protected int dophangiai;
        protected double tocdoin;
       
        public override void Input()
        {
            Console.WriteLine("May in laser");
            base.Input();

            Console.Write("Nhap do phan giai:");
            this.dophangiai = int.Parse(Console.ReadLine());

            Console.Write("Nhap toc do in :");
            this.tocdoin = double.Parse(Console.ReadLine());
        }

        public override string Display()
        {
            return string.Format("Trong luong {0}; " +
                "Nam san xuat: {1}; " +
                "Hang san xuat: {0};" + 
                "do phan giai: {0}; " +
                "Toc do in: {1}",
                this.tr_luong, this.nsx, this.hsx, this.dophangiai,this.tocdoin);

        }
    }
}
