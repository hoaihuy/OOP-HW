using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    class Letter : Airmail
    {

        private bool kindletter;
        private double deli_fee;

        public override void Input()
        {
            base.Input();
            Console.WriteLine("  Enter Kind Letter you want send: ");
            Console.WriteLine("    Enter 0 to send normally");
            Console.WriteLine("    Enter 1 to send fast");
            Console.Write("   Enter value: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (x)
            {
                case 0:
                    kindletter = false;
                    break;
                case 1:
                    kindletter = true;
                    break;
                
            }

            if (kindletter) deli_fee = 5000;
            else deli_fee = 1000;
        }

        public double Delivery_Fee()
        {
            return this.deli_fee;
        }

        public override void Displate()
        {
            base.Displate();
            Console.WriteLine(Delivery_Fee());
        }

    }
}
