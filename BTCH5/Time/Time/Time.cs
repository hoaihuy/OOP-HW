using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Time

    {
        int hours;
        int minutes;

        public Time ()
        {
            this.hours = 0;
            this.minutes = 0;
            
        }
        public Time (int hour, int minute)
        {
            bool check = true;   
            if(hour<0 || hour > 12)
            {
                this.hours = 0;
                this.minutes = minute;
                check = false;
               
            }
            if(minute<0 || minute> 60)
            {
                if (minute > 60) this.hours++;
                else
                this.hours = hour;
                this.minutes = 0;
                check = false;
            }
            if (check==false)
            {
                return;
            }
            this.hours = hour;
            this.minutes = minute;
        }
        public Time(int minute)
        {
            this.hours = minute / 60;
            this.minutes = minute- this.hours*60 ;
        }
        public Time AddMinutes(int m)
        {
            int temp = this.minutes + m;
            if(temp>= 60)
            {
                this.minutes = temp - 60;
                this.hours++;
            }
            else
                this.minutes = temp;
            
            
            return new Time( this.hours,  this.minutes) ;
     
        }
        
        public Time AddHours(int h)
        {
            int temp = this.hours + h;
            if (temp >= 12)
            {
                this.hours = temp - 12;
            }
            else this.hours = h;
            return new Time(this.hours, this.minutes);
        }

        public void PrintMilitaryTime()
        {
            if (this.IsPM())
                this.hours = this.hours + 12;
            if (this.hours == 24 && this.minutes == 0)
                this.hours = 0;

        }

        public Time SubtractMinutes(int m)
        {
            int temp = this.minutes - m;
            if (temp < 0)
            {
                this.minutes = temp + 60;
                this.hours--;
            }
            else
                this.minutes = temp;


            return new Time(this.hours, this.minutes);
        }

        public bool PriorTo(Time t)
        {
            if (t.hours >= this.hours) return true;
            if (t.minutes > this.minutes) return true;
            return false;
        }

        public bool Equals(Time t)
        {
            if (t.hours == this.hours && t.minutes==this.minutes)
                return true;
            return false;
        }

        public bool After(Time t)
        {
            if (t.PriorTo(this))
                return true;
            return false;
        }

        public int SubstractTime(Time t)
        {
            if(this.Equals(t)) Math.Abs(this.minutes - t.minutes) ;
            return Math.Abs(this.hours - t.hours);
        }

       /* public int GetHour()
        {
          
        }
        
        public int GetMinute()
        {
            
        }
        */
        public bool IsPM()
        {
            bool check = false;
            string A="";
            while (check == true)
            {
                
                Console.WriteLine("Enter: AM or PM");
                 A = Console.ReadLine();
                switch (A)
                {
                    case "am":
                        A = "AM";
                        break;
                    case "pm":
                        A = "PM";
                        break;
                    default:
                        Console.WriteLine("Enter again!!!");
                        check = false;
                        break;
                }

            }
            if (A == "PM")
            {
                return true;
            }
            return false;
        }

        public void PrintTime()
        {
            
            Console.WriteLine("{0}:{1} AM", this.hours, this.minutes);
            
        }

    }
}
