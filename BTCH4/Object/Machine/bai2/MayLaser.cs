using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class MayLaser : May
    {
        protected int DoPhanGiai { get; set; }
        protected double TocDoIn { get; set; }
       

        public override void Input()
        {
            Console.WriteLine("May in laser");
            base.Input();

            Console.Write("Nhap do phan giai:");
            this.DoPhanGiai = int.Parse(Console.ReadLine());

            Console.Write("Nhap toc do in :");
            this.TocDoIn = double.Parse(Console.ReadLine());
        }

        public override string Display()
        {
            return base.Display()
                + string.Format("Do phan giai: {0}; " +
                "Toc do in: {1}",
                this.DoPhanGiai,this.TocDoIn);

        }
    }
}
