using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter number of array");
            int n = int.Parse(Console.ReadLine());
            Airmail[] a = new Airmail[n];
            // nhap 2 hang  hoa va 2 thu
            //for(int i=0; i<4;i++)
            //{
            //    if (i < 2)
            //    {
            //        Console.Write("Enter Goods {i} : ");
            //        a[i] = new Goods();
            //        a[i].Input();
            //    }
            //    else
            //    {
            //        a[i] = new Letter();
            //        a[i].Input();
            //    }

            //}
            bool kt = true;
            int x = 0;
            // nhap tu chon hang hoa hay thu
            while(kt)
            {
                Console.WriteLine();
                Console.WriteLine("1-Airmail is Goods");
                Console.WriteLine("2-Airmail is Letter");
                Console.WriteLine("3-Exit");
                Console.Write("Enter your value: ");
                int c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 1:
                        {
                            a[x] = new Goods();
                            a[x].Input();
                            x++;
                            break;
                        }
                    case 2:
                        {
                            a[x] = new Letter();
                            a[x].Input();
                            x++;
                            break;
                        }
                    case 3:
                        kt = false;
                        break;
                      
                }
                if (x == n) kt = false;
            }

            Console.WriteLine("Name's reciever who you want to search");
            string name = Console.ReadLine();
            // đếm tổng số hàng hóa
            int dem = 0;
            double total=0;
            for(int i=0; i<x;i++)
            {
                if (a[i] is Goods)
                {
                    dem++;
                    Goods g = a[i] as Goods;
                    total = g.Delivery_Fee() + total;
                }
                if(a[i] is Letter)
                {
                    Letter l = a[i] as Letter;
                    total = l.Delivery_Fee() + total;
                    if (a[i].receiver == name) a[i].Input();
                }

            }
            Console.WriteLine("Count Goods: "+dem);
            Console.WriteLine("Total Deleivery fee: " + total);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
