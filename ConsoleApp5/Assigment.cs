using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Assignment
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public double Score { get; set; }

        // Default Constructor
        public Assignment() { }

        // Parameterized Constructor
        public Assignment(string title, DateTime dueDate, double score)
        {
            Title = title;
            DueDate = dueDate;
            Score = score;
        }

        // Method to show assignment details
        public void ShowDetails()
        {
            Console.WriteLine($"Title: {Title}, Due Date: {DueDate.ToShortDateString()}, Score: {Score}");
        }
    }
}
