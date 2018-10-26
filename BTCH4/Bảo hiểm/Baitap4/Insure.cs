using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5
{
    class Insure
    {
        public string name;
        public int month;
        public int moneyhaveto_month;
        public int moneyhaveto;

        public void Input()
        {
            Console.Write("Enter customer name: ");
            name = Console.ReadLine();

            Console.Write("Enter month: ");
            month = int.Parse(Console.ReadLine());

            Console.Write("Enter total money customer have to pay: ");
            moneyhaveto = int.Parse(Console.ReadLine());

            if (month > 12)
                Console.Write("Enter money have to pay each month: ");
            moneyhaveto_month = int.Parse(Console.ReadLine());
        }

    }
}
