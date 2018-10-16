using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Computer : Machine
    {
        private int speed;
        private int ram;
        private int hdd;

        public new void Input()
        {
            base.Input();
            Console.WriteLine("Enter number of Speed: ");
            this.speed = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Size of Ram: ");
            this.ram = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Size of HDD:");
            this.hdd = int.Parse(Console.ReadLine());
        }

        public new void Output()
        {
            base.Output();
            Console.WriteLine("Speed: " + this.speed);
            Console.WriteLine("Size of Ram: " + this.ram);
            Console.WriteLine("Size of HDD: " + this.hdd);
        }
    }
}
