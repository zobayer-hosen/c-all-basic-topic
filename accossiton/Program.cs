using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accossiton
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("mmmar",4);
            Car c2 = new Car("uiseuue",4);

            Car[] cars = new Car[] { c1, c2 };
            Person person = new Person("Mr.c", 40, cars);
            person.ShowDetails();

            Student s1 = new Student("zobayer", 22);
            Student s2 = new Student("niju", 24);

            Student[] students = new Student[] { s1, s2 };
            University u = new University("aiub", 1991, students);
            u.Showdetails();

        }
    }
}
