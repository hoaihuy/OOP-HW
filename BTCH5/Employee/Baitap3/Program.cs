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
            // int x = 0;
            // Employee[] e = new Employee[100];
            List l = new List(); 
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
                            // e[x] = new WagedEmployee(name, year, month, day, wage, hours);
                            // e[x].SetAddress(street, city);
                            // Console.WriteLine(e[x].DisplayStat());
                            // x++;
                            WagedEmployee we = new WagedEmployee(name, year, month, day, wage, hours);
                            we.SetAddress(street, city);
                            l.Insert(we);
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
                            //  e[x] = new SalariedEmployee(name, year, month, day, salary);
                            //  e[x].SetAddress(street, city);
                            //  Console.WriteLine(e[x].DisplayStat());
                            // x++;
                            SalariedEmployee se = new SalariedEmployee(name, year, month, day, salary);
                            se.SetAddress(street, city);
                            l.Insert(se);
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
                            //  e[x] = new SalesEmployee(name, year, month, day, salary, commission, sales);
                            // e[x].SetAddress(street, city);
                            //  Console.WriteLine(e[x].DisplayStat());
                            //  x++;
                            SalesEmployee se = new SalesEmployee(name, year, month, day, salary, commission, sales);
                            se.SetAddress(street, city);
                            l.Insert(se);
                            break;
                        }

                    case "4":
                        {
                            //in ra tat ca thong tin tren mang

                            //for(int i=0;i<x;i++)
                            //{
                            //    Console.WriteLine(e[i].DisplayStat());
                            //}
                            EmployeeCollection e = new EmployeeCollection();
                            //thêm các đối tượng với cú pháp chỉ mục
                            e["huy"] = new Employee("huy", 1998, 12, 12);
                            e["Binh"] = new Employee("Binh",1998,12,30);
                            //lấy đối tượng sử dụng chỉ mục
                            for (int i = 0; i < e.Count; i++)
                                Console.WriteLine(e[i].DisplayStat());
                            Console.WriteLine(e[1].DisplayStat());
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
