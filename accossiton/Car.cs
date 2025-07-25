using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace accossiton
{
    class Car
    {
        private string model;
        private int noOfWheels;

        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int NoOfWheels
        {
            get { return this.noOfWheels; }
            set { this.noOfWheels = value; }
        }

        public Car()
        {

        }
        public Car(string model, int noOfWheels)
        {
            this.model = model;
            this.noOfWheels = noOfWheels;
        }
        public void ShowDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Car Details: ");
            Console.WriteLine("Model :"+this.model);
            Console.WriteLine("No of Wheels: " + this.noOfWheels);


        }
    }
}
