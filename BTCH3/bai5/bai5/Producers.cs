using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Producers
    {
        private string name;
        private string address;
        public void Input()
        {
            Console.Write("Enter name");
            this.name = Console.ReadLine();
            Console.Write("Enter address");
            this.address = Console.ReadLine();
        }
        public void Output()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.address);
        }
    }
}
