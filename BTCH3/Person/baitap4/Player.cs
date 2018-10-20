using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    class Player: Person
    {
        private int number;
        private string position;
        private Team team;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public void SetTeam(Team team)
        {
            this.team = team;
        }

        public Player() { }

        public Player(string name, int age, string nationality, int number, string position,Team t)
            :base(name,age,nationality)
        {
            this.number = number;
            this.position = position;
            this.team = t;
        }


        public new void Display()
        {
            base.Display();
            Console.WriteLine("--Number: " + this.number);
            Console.WriteLine("--Position: " + this.position);
            Console.WriteLine("--Team: " + this.team.Name);
        }
    }
}
