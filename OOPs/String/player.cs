using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs.String
{
    public class player
    {


        private int runs;
        private string name;

        public player(int runs, string name)
        {
            this.runs = runs;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{runs}-->{name}";
        }

    }
    public class Team : IEnumerable
    {
        private player[] players;
        public Team()
        {
            players = new player[3];
            {
                new player(5000, "Virat");
                new player(4000, "Sachin");
                new player(3000, "Rohit");
            }
        }
        public IEnumerator GetEnumerator()
        {
            return players.GetEnumerator();
        }
    }

    public class program
    {
        static void Main(string[] args)
        {
            Team team = new Team();

            foreach (player item in team)
            {
                Console.WriteLine(item);
            }
        }
    }
}