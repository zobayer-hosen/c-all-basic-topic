using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Assignment> Assignments { get; set; }

        // Default Constructor
        public Student()
        {
            
        }

        // Parameterized Constructor
        public Student(int studentId, string name, List<Assignment> assignments)
        {
            StudentId = studentId;
            Name = name;
            Assignments = assignments;
        }

        // Method to get pending assignments
        public List<Assignment> GetPendingAssignments()
        {
            return Assignments.Where(a => a.DueDate > DateTime.Now).ToList();
        }

        // Method to show student details
        public void ShowDetails()
        {
            Console.WriteLine($"Student ID: {StudentId}, Name: {Name}, Total Assignments: {Assignments.Count}");
        }
    }
}
