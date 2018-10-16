using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            TienDien t1 = new TienDien();
            TienDienMoi t2 = new TienDienMoi();

            t2.Input();

            //Console.WriteLine("Nhap so cong to dien");
            //t1.Cong_to_dien = int.Parse(Console.ReadLine());

            Console.WriteLine(t2.Display());

            

            Console.WriteLine("So cong to dien da dung: {0}", t1.Cong_to_dien);
            
            Console.WriteLine(t1.Tinh_tien_dien());


            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
