using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static structure.AddressFromat;

namespace structure
{
    interface University
    {
        void Department_name();
    }

    interface Student
    {
        void Student_name();
    }

    public class Othor
    {
        public void Othreities()
        {
            Console.WriteLine("the authorities is the main character in aiub");
        }
    }

    class Gurdian : Othor, University, Student
    {
        public void Department_name()  // ✅ Corrected spelling
        {
            Console.WriteLine("my name is Zobayer Hosen");
        }

        public void Student_name()
        {
            Console.WriteLine("he is the boss");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.Id = 100;
            //s1.Name = "zobayer";
            //s1.Cgpa = 3.21;
            //s1.BloodGroup = "o+";
            //s1.Address= new AddressFromat(12, 34, 778, "chattogram");
            //s1.PrintStudentInfo();
            //Student s2 = new Student(200, "Clerk", -3.19, "ab+", new AddressFromat(22, 87, 4390, "Sylhet"));
            //s2.PrintStudentInfo();


            Gurdian ob1 = new Gurdian();
            ob1.Department_name();
            ob1.Student_name();



        }
    }
}
