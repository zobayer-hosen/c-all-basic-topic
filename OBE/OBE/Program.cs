using System;

namespace ConsoleAppCricketUserldCup
{
    // Base Player class
    public abstract class Player
    {
        // Fields
        protected string playerId;
        protected string playerName;
        protected string teamName;

        // Constructor
        public Player(string id, string name, string team)
        {
            playerId = id;
            playerName = name;
            teamName = team;
        }

        // Virtual method to show player info
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Player ID: {playerId}");
            Console.WriteLine($"Player Name: {playerName}");
            Console.WriteLine($"Team: {teamName}");
        }

        // Abstract method to determine award eligibility
        public abstract bool PlayerPerformance();
    }



    // Batsman class
    public class Batsman : Player
    {
        // Additional fields
        private int totalRuns;
        private double battingAverage;
        private int highestScore;

        // Constructor
        public Batsman(string id, string name, string team, int runs, double avg, int highScore)
            : base(id, name, team)
        {
            totalRuns = runs;
            battingAverage = avg;
            highestScore = highScore;
        }

        // Override ShowInfo to include batsman-specific info
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Type: Batsman");
            Console.WriteLine($"Total Runs: {totalRuns}");
            Console.WriteLine($"Batting Average: {battingAverage}");
            Console.WriteLine($"Highest Score: {highestScore}");
            Console.WriteLine($"Award Eligible: {(PlayerPerformance() ? "Yes" : "No")}");
        }

        // Implement performance criteria for batsman
        public override bool PlayerPerformance()
        {
            return battingAverage > 50;
        }
    }

    // Bowler class
    public class Bowler : Player
    {
        // Additional fields
        private int totalWickets;
        private double bowlingAverage;

        public int TotalWickets
        {
            get { return this.TotalWickets; }
            set { this.totalWickets = value; }
        }

        // Constructor
        public Bowler(string id, string name, string team, int wickets, double avg)
            : base(id, name, team)
        {
            totalWickets = wickets;
            bowlingAverage = avg;
        }

        // Override ShowInfo to include bowler-specific info
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Type: Bowler");
            Console.WriteLine($"Total Wickets: {totalWickets}");
            Console.WriteLine($"Bowling Average: {bowlingAverage}");
            Console.WriteLine($"Award Eligible: {(PlayerPerformance() ? "Yes" : "No")}");
        }

        // Implement performance criteria for bowler
        public override bool PlayerPerformance()
        {
            return totalWickets > 100;
        }
    }

    // AllRounder class
    public class AllRounder : Player
    {
        // Additional fields
        private int totalRuns;
        private int totalWickets;

        // Constructor
        public AllRounder(string id, string name, string team, int runs, int wickets)
            : base(id, name, team)
        {
            totalRuns = runs;
            totalWickets = wickets;
        }

        // Override ShowInfo to include all-rounder-specific info
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Type: All-Rounder");
            Console.WriteLine($"Total Runs: {totalRuns}");
            Console.WriteLine($"Total Wickets: {totalWickets}");
            Console.WriteLine($"Award Eligible: {(PlayerPerformance() ? "Yes" : "No")}");
        }

        // Implement performance criteria for all-rounder
        public override bool PlayerPerformance()
        {
            return totalRuns > 1000 && totalWickets > 50;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[4];
            players[0] = new Batsman("P-1", "Tom Latham", "NZ", 6789, 57.3, 183);
            players[1] = new Bowler("P-2", "Taskin Ahmed", "BD", 180, 21.2);
            players[2] = new AllRounder("P-3", "Glenn Maxwell", "AUS", 7598, 98);
            players[3] = new AllRounder("P-4", "Sam Curran", "Eng", 781, 60);
            
            foreach (Player player in players)
            {
                player.ShowInfo();
                Console.WriteLine();
            }
        }
    }
}