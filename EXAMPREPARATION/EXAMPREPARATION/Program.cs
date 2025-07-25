using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPREPARATION
{
    class Program
    {
        static void Main(string[] args)
        {
            Fatherofstudent fs = new Fatherofstudent();
            string a = fs.BloodGroup = "o+";
            string b = fs.Name = "abdul kalek";
            int c= fs.Age = 50;
            Fatherofstudent.keyMethod();
            Console.WriteLine("boodGroup  " + a + "name of father   " + b + "age of father   " + c);

            Console.WriteLine("\n");
            fs.Showdetails();



            Console.WriteLine("\n");
            Fatherofstudent fss = new Fatherofstudent("  kokhon", 22, "  b+");
            Fatherofstudent.keyMethod();
            Console.WriteLine(fss.Name +" "+ fss.Age +" "+ fss.BloodGroup);

            Student s = new Student();
            s.Name = "  Alif";
            s.Age = 22;
            s.BloodGroup = "o+";
            s.Department = "CSE";
            s.Cgpa = 3.50f;
            Fatherofstudent.keyMethod();
            Console.WriteLine(s.Name +" "+
            +s.Age +" "+
            s.BloodGroup +" "+
            s.Department +" "+
            s.Cgpa);

            Console.WriteLine("\n");
            s.Showdetails();

            Student ss = new Student("  zobayer", 23, "  o+", 3.50f, "  CSE");
            Fatherofstudent.keyMethod();
            Console.WriteLine(ss.Name + " " + ss.Age + " " + ss.BloodGroup + " " + ss.Cgpa + "  " + ss.Department);
            Console.WriteLine("\n");
            ss.Showdetails();
            ss.StudentCgpa();
            ss.departmentName();



        }
    }
}
