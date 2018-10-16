using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter number of computer: ");
            int n = int.Parse(Console.ReadLine());

            Computer computer = new Computer();
            computer.Input();

            //Computer[] computer = new Computer[n];
            //for(int i=0; i<n; i++)
            //{
            //    computer[i] = new Computer();
            //}
            //foreach(Computer dem in computer)
            //{
            //    dem.Input();
            //}

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
