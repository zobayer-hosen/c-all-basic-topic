using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accossiton
{
    class Person
    {
        private string personName;
        private int age;
        private Car[] cars;


        public string PersonName
        {
            get { return this.personName; }
            set { this.personName = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public Car[] Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }
        public Person()
        {

        }
        public Person(string personName,int age, Car[] cars)
        {
            this.personName = personName;
            this.age = age;
            this.cars = cars;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Person Name :" + this.personName);
            Console.WriteLine("Age " + this.age);
            for(int i =0; i<this.cars.Length; i++)
            {
                if (this.cars[i]!= null)
                {
                    this.cars[i].ShowDetails();
                }
            }
        }
    }
}
