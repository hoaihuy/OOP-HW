using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    abstract class May
    {
        protected string tr_luong;
        protected string nsx;
        protected string hsx;

        public virtual void Input()
        {
            Console.Write("nhap trong luong:");
            this.tr_luong = Console.ReadLine();

            Console.Write("nhap nam san xuat:");
            this.nsx = Console.ReadLine();

            Console.Write("nhap hang san xuat:");
            this.hsx = Console.ReadLine();
        }

        public abstract string Display();
    }
}
