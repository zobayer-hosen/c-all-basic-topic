using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CricketworldCup
{
    public class Batsman : Player
    {
        private int totalRun;
        private float totalAverage;
        private int highestScore;

        public int TotalRun
        {
            get { return this.TotalRun; }
            set { this.totalRun = value; }
        }
        public float TotalAverage
        {
            get { return this.totalAverage; }
            set { this.totalAverage = value; }
        }
        public int HighestScore
        {
            get { return this.highestScore; }
            set { this.highestScore = value; }

        }
        public Batsman(string playerId, string playername, string teamname, int totalRun, float totalAverage, int hightScore) : base(playerId, playername, teamname)
        {
            this.totalRun = totalRun;
            this.totalAverage = totalAverage;
            this.highestScore = hightScore;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("total run" + this.totalRun);
            Console.WriteLine("total Average" + this.totalAverage);
            Console.WriteLine("total higestScore" + this.highestScore);
            Console.WriteLine("the performane ward" + this.PlayerPerformance());
        }

        public override bool PlayerPerformance()
        {
            if (this.totalAverage <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
