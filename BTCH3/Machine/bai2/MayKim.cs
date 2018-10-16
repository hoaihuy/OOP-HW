using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class MayKim : May
    {
        protected int sokim;
        protected double tocdoin;

        public new void Input()
        {
            Console.WriteLine("May in Kim");

            base.Input();

            Console.Write("Nhap so kim:");
            this.sokim = int.Parse(Console.ReadLine());

            Console.Write("Nhap toc do in :");
            this.tocdoin = double.Parse(Console.ReadLine());
        }

        public new string Display()
        {
            return base.Display()
                + string.Format("So kim: {0}; Toc do in: {1}",
                this.sokim, this.tocdoin);

        }
    }
}
