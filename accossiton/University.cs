using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accossiton
{
    class University
    {
        private string unName;
        private int establish;
        private Student[] students;

        public string UnName
        {
            get { return this.unName; }
            set { this.unName = value; }
        }
        public int Establish
        {
            get { return this.establish; }
            set { this.establish = value; }
        }
        public Student[] Students
        {
            get { return this.students; }
            set { this.students = value; }
        }
        public University()
        {

        }
        public University(string unName,int establish, Student[] students)
        {
            this.unName = unName;
            this.establish = establish;
            this.students = students;
        }
        public void Showdetails()
        {
            Console.WriteLine();
            Console.WriteLine(this.unName);
            Console.WriteLine(this.establish);
            for(int i=0; i < this.students.Length; i++)
            {
                if (this.students[i] != null)
                {
                    students[i].Showdetails();
                }
            }

        }
    }
}
