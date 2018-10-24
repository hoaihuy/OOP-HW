using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    class Letter
    {
        public string address;
        public string receiver;
        public bool kindletter;
        public double deli_fee;

        public virtual void Input()
        {
            Console.Write("Enter Address: ");
            this.address = Console.ReadLine();

            Console.Write("Enter Reciever: ");
            this.receiver = Console.ReadLine();

            Console.WriteLine("Enter Kind Letter you want send: ");
            Console.WriteLine("Enter 0 to send normally");
            Console.WriteLine("Enter 1 to send fast");
            Console.Write("Enter value: ");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 0:
                    kindletter = false;
                    break;
                case 1:
                    kindletter = true;
                    break;
            }

        }

        
    }
}
