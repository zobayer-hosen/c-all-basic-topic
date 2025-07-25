using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPREPARATION
{
    public class Student:Fatherofstudent
    {
        private float cgpa;
        private string department;

        public float Cgpa
        {
            get { return this.cgpa; }
            set { if (value == 0.0f || value == 4.0f)
                    this.cgpa = cgpa;
                else
                    this.cgpa = -1;
                }
        }
        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public Student():base()
        {
            Console.WriteLine("student default constructor");
        }
             
        public Student(string name,int age,string bloodGroup,float cgpa,string department) :base(name, age, bloodGroup)
        {
            Console.WriteLine("student class paramiterize constructor");
            this.cgpa = cgpa;
            this.department = department;
        }

        public override void Showdetails()
        {
            Console.WriteLine("this is a override method");
            base.Showdetails();
            Console.WriteLine("student cgpa" + this.cgpa);
            Console.WriteLine("student department" + this.department);


        }
        //custom method
        public string StudentCgpa()
        {
            if (this.cgpa == 3.5f && this.cgpa == 4.00f)
               { return "you get A+"; }

            else if(this.cgpa == 3.00f && this.cgpa == 3.49f){
                return "you get b+";
            }
            else
            {
                return "you fail";
            }

            
        }
        public void departmentName()
        {
            if (this.department == "CSE")
            {
                Console.WriteLine("the stuent study in CSE");
            }
            else if (this.department == "EEE")
            {
                Console.WriteLine("the student study in EEE ");
            }
            else
            {
                Console.WriteLine("the student study in others department");
            }
        }


    }
}
