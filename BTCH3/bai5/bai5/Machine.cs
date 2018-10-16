using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Machine
    {
        string logo;
        Producers nsx;
        int price;
        public void Input()
        {
            //this.nsx.Input();
            Console.Write("Enter logo: ");
            this.logo = Console.ReadLine();
            Console.Write("Enter price: ");
            this.price = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine(this.logo);
            //Console.WriteLine(this.nsx);
            //this.nsx.Output();

        }
    }
}
