using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    abstract class May
    {
        protected double TrongLuong { get; set; }
        protected string Namsx { get; set; }
        protected string Hangsx { get; set; }

        //public May() { }
        //public May (double tl, string namsx, string hangsx)
        //{
        //    TrongLuong = tl;
        //    Namsx = namsx;
        //}

        public virtual void Input()
        {
            Console.Write("nhap trong luong:");
            this.TrongLuong =double.Parse( Console.ReadLine());

            Console.Write("nhap nam san xuat:");
            this.Namsx = Console.ReadLine();

            Console.Write("nhap hang san xuat:");
            this.Hangsx = Console.ReadLine();
        }

        public virtual string Display()
        {

            return string.Format("Trong luong {0}; " +
                "Nam san xuat: {1}; " +
                "Hang san xuat: {0};",
                this.TrongLuong,this.Namsx, this.Hangsx);
        }
    }
}
