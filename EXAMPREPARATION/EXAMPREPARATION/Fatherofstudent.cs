using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EXAMPREPARATION
{
    public class Fatherofstudent
    {
        protected string name;
        protected int age;
        protected string bloodGroup;
        protected static int key;


        public static void keyMethod()
        {
           Console.WriteLine( "this is the key word   "+ key++);
        }

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
        public string BloodGroup
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public Fatherofstudent()
        {
            Console.WriteLine("father of student default constructor");
        }
        public Fatherofstudent(string name,int age,string bloodGroup)
        {
            Console.WriteLine("father of student parameterize constructor");
            this.name = name;
            this.age = age;
            this.bloodGroup = bloodGroup;

        }

        public virtual void Showdetails()
        {
            Console.WriteLine("this is father showdetails method");
            Console.WriteLine("student father name " + this.name);
            Console.WriteLine("student father age" + this.age);
            Console.WriteLine("student father blood group" + this.bloodGroup);

        }
        
    }
}
