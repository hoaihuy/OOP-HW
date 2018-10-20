using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Coach c = new Coach("Huy", 40, "Vietnam", 1998);
            Team t = new Team("Viet Nam",c);
            Team a = new Team("Thai Land",c);
            Player p1 = new Player("Yen", 20, "Indian", 7, "Tien dao",t);
            Player p2 = new Player("Tin", 20, "Vietnam", 17, "Thu mon",t);
            Player p3 = new Player("Nhi", 20, "Thailand", 47, "Hau ve",a);

            

            t.AddPlayer(p1);
            t.AddPlayer(p2);
            t.AddPlayer(p3);

            t.Display();
            a.Display();
            

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
