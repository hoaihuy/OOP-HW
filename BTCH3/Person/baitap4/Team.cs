using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap4
{
    class Team
    {
        private string name;
        private List<Player> players;
        private Coach Coach;

        public void Display()
        {
            Console.WriteLine("Name of Team: " + name);

        }
    }
}
