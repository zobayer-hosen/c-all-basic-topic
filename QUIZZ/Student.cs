using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZZ
{
    class Student
    {
        private int age;
        private int cls;
        private Address[] std;

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public int Cls
        {
            get { return this.cls; }
            set { this.cls = value; }
        }
        public Student()
        {

        }
        public Student(int age, int cls, Address[] std)
        {
            this.age = age;
            this.cls = cls;
            this.std = std;
        }
        public void Show()
        {
            Console.WriteLine();
            Console.WriteLine(this.age);
            Console.WriteLine(this.cls);
       
           for( int i =0; i<std.Length; i++)
            {
                if (this.std[i] != null)
                {
                   this. std[i].showdetils();

                }

            }


        }

    }
}
