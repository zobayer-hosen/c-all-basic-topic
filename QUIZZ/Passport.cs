using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZZ
{
    public class Passport
    {
        private string name;
        private int age;
        private string address;


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
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }

        }
        public Passport()
        {

        }
        public Passport(string name, int age , string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("the citizen name is " + this.name);
            Console.WriteLine("the citizen age is " + this.age);
            Console.WriteLine("the citizen address is " + this.address);

        }
    }
}
