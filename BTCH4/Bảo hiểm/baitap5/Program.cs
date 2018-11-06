using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap5
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");

            Employee e = new Employee("Huy", 2.0);
            List<Insure> l = new List<Insure>();
            l.Add(new InsureL("Yen", 15, 1000));
            l.Add(new InsureL("Hoai", 25, 1000));
            l.Add(new InsureL("Tung", 13, 1000));
            l.Add(new InsureS("Thao", 11, 1000));
            l.Add(new InsureS("Lam", 7, 1000));

            foreach (Insure dem in l)
                e.SetInsure(dem);

            e.Displate();
            
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
