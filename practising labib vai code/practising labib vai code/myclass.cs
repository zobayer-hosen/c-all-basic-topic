using System;
using System.Diagnostics;

namespace practising_labib_vai_code
{
    struct AddressFormat  // Fixed spelling from "AdressFromet"
    {
        private string name;
        private ulong age; // 64 bit positive number 
        private int weight; // 32 bit (not 16) carries both negative and positive values
        private string bloodGroup; // Fixed spelling from "boodGroup"

        // Properties with proper validation logic
        public string Name
        {
            get { return name; }
            set
            {
                if (value == "zobayer") // Removed space before "zobayer"
                    this.name = value;
                else
                    this.name = default;
            }
        }

        public ulong Age
        {
            get { return age; }
            set
            {
                if (value == 23)
                    age = value;
                else
                    this.age = default;
            }
        }

        public int Weight
        {
            get { return weight; }
            set
            {
                if (value == 60)
                    weight = value;
                else
                    Console.WriteLine("i am confused about this");
            }
        }

        public string BloodGroup // Fixed spelling from "BoodGoup"
        {
            get { return bloodGroup; }
            set
            {
                if (value == "o+")
                    bloodGroup = value; // Fixed recursive setter (was BoodGoup = value)
                else
                    Console.WriteLine("i don't need others blood group i just need this o+");
            }
        }

        // Constructor fixes
        public AddressFormat(string name, ulong age, int weight, string bloodGroup)
        {
            this.name = name;
            this.age = age;
            this.weight = weight; // Fixed parameter name from "weigth" to "weight"
            this.bloodGroup = bloodGroup;
        }

        public void showDetails()
        {
            Console.WriteLine("this is the way to see everthing ");
            Console.WriteLine("name of " + this.name);
            Console.WriteLine("age of " + this.age);
            Console.WriteLine("the weight of" + this.weight);
            Console.WriteLine("the bood group" + this.bloodGroup);
        }
    }
    public class Student
    {
        private float cgpa;
        private string department;
        private int session;
        private AddressFormat address;

        public float Cgpa
        {
            get { return this.cgpa; }
            set {  if (value >= 0.0 && value <= 4.00)
                    this.cgpa = value;

                else
                    this.cgpa = -1;
            }
        }

    }

}