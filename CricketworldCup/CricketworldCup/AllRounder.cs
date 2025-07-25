using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CricketworldCup
{
    class AllRounder:Player
    {
        private int totalRun;
        private int totalWicket;

        public int TotalRun
        {
            get { return this.TotalRun; }
            set { this.totalRun = value; }
        }
        public int TotalWicket
        {
            get { return this.TotalWicket; }
            set { this.totalWicket = value; }
        }
        public AllRounder(string palyerId,string playername,string teamname, int totalRun,int totalWicket) : base(palyerId, playername, teamname)
        {
            this.totalRun = totalRun;
            this.totalWicket = totalRun;

        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("total run" + this.totalRun);
            Console.WriteLine("total Wicket" + this.TotalWicket);
            Console.WriteLine(this.PlayerPerformance());



        }
        public override bool PlayerPerformance()
        {
            if(this.totalRun<=100 && this.totalWicket<=50)
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