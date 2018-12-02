using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Time t = new Time(8, 30);

            
           /*
            */
            PrintSchedule(t, 30, 6);
            Console.ReadKey();
        }
        public static void PrintSchedule(Time start, int apptLength, int numberOfAppts)
        {
            for (int i = 0; i < numberOfAppts-1; i++)
            {
                start.PrintTime();
                start.SubtractMinutes(apptLength);
                if (start.PriorTo(start))
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }
            
        }
    }
}
