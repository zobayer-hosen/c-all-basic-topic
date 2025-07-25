using CricketworldCup;
using System;

public class Bowler : Player
{
    private int totalWickets;  // Changed to plural to match requirements
    private float bowlingAverage;

    // Corrected constructor with all needed parameters
    public Bowler(string playerId, string playerName, string teamName,
                 int totalWickets, float bowlingAverage)
        : base(playerId, playerName, teamName)  // Proper base constructor call
    {
        this.totalWickets = totalWickets;
        this.bowlingAverage = bowlingAverage;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Total Wickets: {this.totalWickets}");
        Console.WriteLine($"Bowling Average: {this.bowlingAverage}");
        Console.WriteLine($"Award Eligible: {(this.PlayerPerformance() )}");
    }

    public override bool PlayerPerformance()
    {
        if (this.totalWickets <= 100)
        {
            return true;
        }
        else
        {
            return false;

        }
    }
}