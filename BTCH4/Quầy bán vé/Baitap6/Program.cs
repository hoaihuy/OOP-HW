using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap6
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            BoxOffice b = new BoxOffice(); 
            List<Price> pr = new List<Price>();
            pr.Add(new PrElderly());
            pr.Add(new PrElderly());
            pr.Add(new PrElderly());
            pr.Add(new PrElderly());

            pr.Add(new PrChildren());
            pr.Add(new PrChildren());

            pr.Add(new PrAdult());

            foreach( Price dem in pr)
            {
                
            }

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
