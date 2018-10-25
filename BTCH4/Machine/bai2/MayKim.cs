using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class MayKim : May
    {
        protected int SoKim { get; set; }
        protected double TocDoIn { get; set; }


        public override void Input()
        {
            Console.WriteLine("May in Kim");

            base.Input();

            Console.Write("Nhap so kim:");
            this.SoKim = int.Parse(Console.ReadLine());

            Console.Write("Nhap toc do in :");
            this.TocDoIn = double.Parse(Console.ReadLine());
        }

        public override string Display()
        {
            return base.Display()
                + string.Format("So kim: {0};" +
                " Toc do in: {1}",
                this.SoKim, this.TocDoIn);

        }
    }
}
