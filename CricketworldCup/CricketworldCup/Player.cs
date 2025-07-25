using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketworldCup
{
    public class Player
    {
        protected string playerId;
        protected string playername;
        protected string teamname;

        public string PlayerId
        {
            get { return this.playerId; }
            set { this.playerId = value; }
        }
        public string Playername
        {
            get { return this.playername; }
            set { this.playername = value; }

        }
        public string Teamname
        {
            get { return this.teamname; }
            set { this.teamname = value; }
        }
        public Player(string playerId, string playername, string teamname)
        {
            this.PlayerId = playerId;
            this.Playername = playername;
            this.Teamname = teamname;
        }


        public virtual void ShowInfo()
        {
            Console.WriteLine("player ID" + this.PlayerId);
            Console.WriteLine("palyer name" + this.playername);
            Console.WriteLine("player team name" + this.playername);

        }
        public virtual bool PlayerPerformance()
        {
            return false;
        }

    }
}
