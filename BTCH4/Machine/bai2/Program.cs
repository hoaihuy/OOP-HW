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
            
            Console.Write("So may in ");
            n = int.Parse(Console.ReadLine());

            
            May [] may = new May[n];
            
            for(int i=0; i<n;i++)
            {
                bool kt = true;
                while (kt)
                { 
                    Console.WriteLine("Nhap " + "K hoac k de chon May in Kim");
                    Console.WriteLine("Nhap " + "L hoac l de chon May in Laser");
                    Console.Write("Gia tri nhap: ");
                    string x = Console.ReadLine();
                    switch (x)
                    {
                        case "K":
                        case "k":
                            {
                               
                                may[i] = new MayKim();
                                may[i].Input();
                                Console.WriteLine();
                                kt = false;
                                break;
                            }
                        case "L":
                        case "l":
                            { 
                                may[i] = new MayLaser();
                                may[i].Input();
                                Console.WriteLine();
                                kt = false;
                                break;
                            }
                        default:
                            Console.WriteLine("Nhap sai! Vui long nhap lai");
                            break;
                    }
                }

            }

            Console.WriteLine();

            foreach (May dem in may)
            {
                //if (dem is MayKim)
                //{
                //    MayKim k = dem as MayKim;
                //    Console.WriteLine("May Kim: {0}", k.Display());
                //}

                //if (dem is MayLaser)
                //{
                //    MayLaser l = dem as MayLaser;
                //    Console.WriteLine("May Laser: {0}", l.Display());
                //}
                Console.WriteLine(dem.Display());

                Console.WriteLine();
            }




            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
