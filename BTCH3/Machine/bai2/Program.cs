using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!\n");

            int n;
            int m;
            Console.Write("So may in kim:");
            n = int.Parse(Console.ReadLine());

            Console.Write("So may in laser:");
            m = int.Parse(Console.ReadLine());

            MayKim [] maykim = new MayKim[n];
            MayLaser [] maylaser = new MayLaser[m];

            for(int i=0; i<n;i++)
            {
                maykim[i] = new MayKim();

            }
            for (int i = 0; i < m; i++)
            {
                maylaser[i] = new MayLaser();

            }
            Console.WriteLine();
            //input
            foreach (MayKim dem in maykim)
            {
                dem.Input();
                Console.WriteLine();
            }
                
            foreach (MayLaser dem in maylaser)
            {
                dem.Input();
                Console.WriteLine();
            }
                
            //display
            foreach (MayKim dem in maykim)
            {
                Console.WriteLine(dem.Display());
                Console.WriteLine();
            }
               
            foreach (MayLaser dem in maylaser)
            {
                Console.WriteLine(dem.Display());
                Console.WriteLine();
            }
                
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
