using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class May
    {
        protected string tr_luong;
        protected string nsx;
        protected string hsx;

        public void Input()
        {
            Console.Write("nhap trong luong:");
            this.tr_luong = Console.ReadLine();

            Console.Write("nhap nam san xuat:");
            this.nsx = Console.ReadLine();

            Console.Write("nhap hang san xuat:");
            this.hsx = Console.ReadLine();
        }

        public string Display()
        {
            return string.Format("Trong luong {0}; " +
                "Nam san xuat: {1}; " +
                "Hang san xuat: {0}; ", this.tr_luong, this.nsx, this.hsx);

        }
    }
}
