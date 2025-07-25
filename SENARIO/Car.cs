using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENARIO
{
    public class Car : Icar
    {
        private string carName;
        private int model;
        private int speed;

        public  void  Break()
        {
            this.speed--;
            Console.WriteLine("the car is acclerated" + this.speed);


        }
        public void Acclartor()
        {
            this.speed++;
            Console.WriteLine("the car is acclartor" + this.speed);

        }
        public string Carname
        {
            get { return this.carName;}
            set { this.carName = value; }

        }
        public int Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public int Speed
        {
            get { return this.speed; }
            set { this.model = value; }
        }
        public Car()
        {

        }
        public Car(string carName,int model,int speed)
        {
            this.carName = carName;
            this.model = model;
            this.speed = speed;
            Showdetails();
        }
        public void Showdetails()
        {
            Console.WriteLine(" ");
            Console.WriteLine("the is the carname " + this.carName);
            Console.WriteLine("this is model name " + this.model);
            Console.WriteLine("this is car speed" + this.speed);
        }


    }
}
