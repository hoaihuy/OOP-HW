using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    class Goods:Airmail
    {
        private double weight;
        public  double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override void Input()
        {
            base.Input();
            Console.WriteLine("Enter Goods of Weight: ");
            this.weight = double.Parse(Console.ReadLine());
            Console.WriteLine();
        }   

        public double Delivery_Fee()
        {
            return this.Weight * 10000;
        }
        public override void Displate()
        {
            base.Displate();
            Console.WriteLine(Delivery_Fee());
        }
    }
}
