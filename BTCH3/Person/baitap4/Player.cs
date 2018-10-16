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

        public void SetTeam(Team team)
        {
            this.team = team;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Number: " + this.number);
            Console.WriteLine("Number: " + this.position);
            this.team.Display();
        }
    }
}
