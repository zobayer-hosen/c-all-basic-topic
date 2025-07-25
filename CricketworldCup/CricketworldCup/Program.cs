using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CricketworldCup
{
   
    
       
             
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[4];
            players[0] = new Batsman("P-1", "Tom Latham", "H2", 6789, 57, 183);
            players[1] = new Bowler("P-2", "Taskin Ahmed", "BD", 180, 21);
            players[2] = new AllRounder("P-3", "Glenn Maxwell", "AMS", 7598, 98);
            players[3] = new AllRounder("P-4", "Sam Curran", "Eng", 781, 60);

            foreach(Player player in players)
            {
                player.ShowInfo();
            }
        }
    }
}
