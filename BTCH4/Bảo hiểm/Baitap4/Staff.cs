using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap5
{
    class Staff
    {
        public string name;
        public double salarygr;
        Insure [] A;

        public void Input()
        {
            Console.Write("Enter name of staff: ");
            name = Console.ReadLine();

            Console.Write("Enter salary grading of staff: ");
            salarygr = double.Parse(Console.ReadLine());

            Console.Write("Enter total of insure selled by each staff: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                A[i] = new Insure();
            }
        }

        //public string Displate_Insure()
        //{
        //   foreach (Insure dem in A)
        //        Console.WriteLine(dem.name);
        //}

        public void Displate()
        {
            Console.WriteLine("Name staff: {0} " +
                "- Staff grading: {1} " +
                "- Total of insure selled: {2} "
                , name, salarygr );
        }

    }
}
