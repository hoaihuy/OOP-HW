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

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Team() { }

        public Team(string nameT,Coach coach)
        {
            this.name = nameT;
            this.Coach = coach;
            players = new List<Player>();
          
        }

        public void AddPlayer(Player p)
        {
            players.Add(p);
        }
        public void RemovePlayer(Player p)
        {
            players.Remove(p);
        }

        //public void SetCoach(string name, int age, string nationality, int year)
        //{
        //    Coach = new Coach(name,age,nationality,year);
        //}

        //public void SetPlayers(string name, int age, string nationality,
        //    int number, string position)
        //{
        //    players = new Player(name, age, nationality, number, position);
        //}

        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Name of Coach: ");
            Coach.Display();
            Console.WriteLine();
            Console.WriteLine("Name of Team: " + name);
            if (players.Count > 0)
            {
                Console.WriteLine("Player");
                foreach (Player dem in players)
                {
                    dem.Display();
                }
            }
            else
                Console.WriteLine(" No Player");
           
        }

      

        ~Team()
        {
            Coach = null;
            players = null;
        }
    }
}
