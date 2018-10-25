using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("1. Waged Employee");
                Console.WriteLine("2. Salaried Employee");
                Console.WriteLine("3. Sales Employee");
                Console.WriteLine("4. Exit/n");
                Console.WriteLine("Choose an Employee or an Action: ");

                string c = Console.ReadLine();

                string name;				// variables used by all employee types
                int year;
                int month;
                int day;
                string street;
                string city;
                
                // tao ra mot mang kieu Empoy chua 100 phan tu
                Employee[] e = new Employee[100];
                switch (c)
                {
                    case "1":	// waged employee
                        {
                            double wage;
                            double hours;
                            Input("Name", out name);
                            Input("Wage", out wage);
                            Input("Hours", out hours);
                            Input("Year", out year);
                            Input("Month", out month);
                            Input("Date", out day);
                            Input("Street", out street);
                            Input("City", out city);
                            e[x] = new WagedEmployee(name, year, month, day, wage, hours);
                            x++;
                            //we.SetAddress(street, city);
                            //Console.WriteLine(we.DisplayStat());
                            break;
                        }

                    case "2":	// salaried employee
                        {
                            double salary;
                            Input("Name", out name);
                            Input("Salary", out salary);
                            Input("Year", out year);
                            Input("Month", out month);
                            Input("Date", out day);
                            Input("Street", out street);
                            Input("City", out city);
                            SalariedEmployee se = new SalariedEmployee(name, year, month, day, salary);
                            se.SetAddress(street, city);
                            //Console.WriteLine(se.DisplayStat());
                            break;
                        }

                    case "3":	// sales employee
                        {
                            double salary;
                            double commission;
                            double sales;
                            Input("Name", out name);
                            Input("Salary", out salary);
                            Input("Commission", out commission);
                            Input("Sales", out sales);
                            Input("Year", out year);
                            Input("Month", out month);
                            Input("Date", out day);
                            Input("Street", out street);
                            Input("City", out city);
                            SalesEmployee se = new SalesEmployee(name, year, month, day, salary, commission, sales);
                            se.SetAddress(street, city);
                            //Console.WriteLine(se.DisplayStat());
                            break;
                        }

                    case "4":
                        {
                            //in ra tat ca thong tin tren mang
                            foreach (Employee dem in e)
                            {
                                if (dem is WagedEmployee)
                                {
                                    WagedEmployee w = dem as WagedEmployee;
                                    Console.WriteLine(w.DisplayStat());
                                }
                                Console.WriteLine(dem.DisplayStat());
                            }

                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }

        static void Input(string message, out string var)
        {
            Console.WriteLine("{0} : ", message);
            var = Console.ReadLine();
        }

        static void Input(string message, out int var)
        {
            Console.WriteLine("{0} : ", message);
            var = int.Parse(Console.ReadLine());

        }

        static void Input(string message, out double var)
        {
            Console.WriteLine("{0} : ", message);
            var = double.Parse(Console.ReadLine());
        }
    }
}
