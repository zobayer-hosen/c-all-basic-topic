using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accossiton
{
    class Student
    {
        private string name;
        private int age;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Student()
        {

        }
        public Student(string name,int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Showdetails()
        {
            Console.WriteLine();
            Console.WriteLine(this.name);
            Console.WriteLine(this.age);

        }
    }
}
