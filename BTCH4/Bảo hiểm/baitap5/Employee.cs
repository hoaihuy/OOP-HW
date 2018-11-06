using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    class Employee
    {
        public string Name { get; set; }
        public double Payrate { get; set; }
        // các bảo hiểm bán được
        List<Insure> insures;

        public Employee(string name, double payrate)
        {
            this.Name = name;
            this.Payrate = payrate;
            insures = new List<Insure>();
        }

        public void SetInsure(Insure i)
        {
            insures.Add(i);
        }

        public void PrintInsure()
        {
            foreach( Insure dem in insures)
            {
                Console.WriteLine(dem.ToString());
                Console.WriteLine();
            }
        }

        public bool CheckAward()
        {
            foreach (Insure dem in insures)
                if (dem.Money > 100000)
                    return true;
            return false;

        }

        public bool CheckPunish()
        {
            double s = 0;
            foreach (Insure dem in insures)
                s = s + dem.Money;
            if (s < 10000)
                return true;
            return false;
        }


        public double Salary()
        {
            double t=0;
            foreach (Insure dem in insures)
            {
                t = t + (dem.Money-dem.RoseMoney());
            }

            double s = this.Payrate * 40 + 1 / t;

            if (this.CheckPunish()) return s - 30;
            if (this.CheckAward()) return s + 100;
            return s;
        }


        public void Displate()
        {
            Console.WriteLine("------------------Employee------------------");
            Console.WriteLine("Name: {0}-- Payrate: {1} \n", Name, Payrate);
            Console.WriteLine("Salary: " + this.Salary());
            Console.WriteLine("           ----Insure----\n");
            PrintInsure();
            Console.WriteLine("--------------List Employee have RoseMoney >50--------------");
            double rose = 0;
            foreach (Insure dem in insures)
            {
                rose = dem.RoseMoney() + rose;

            }
            if (rose > 50)
                Console.WriteLine(this.Name);
        }

        ~Employee()
        {
            insures = null;
        }





    }
}
