using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    public struct AddressFromat
    {
        private byte houseNo;
        private byte roadNo;
        private ushort postalCode;
        private string dictrict;

        // default constructor is not applicable because deafault constructor provid by compilar

        public AddressFromat(byte houseNo,byte roadNo,ushort postalCode,string dictrict)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.postalCode = postalCode;
            this.dictrict = dictrict;

        }

        public void printAddress()
        {
            Console.WriteLine("Address Information:");
            Console.WriteLine("House No: {0}" + this.houseNo);
            Console.WriteLine("Road No: {0}" + this.roadNo);
            Console.WriteLine("District: {0}" + this.dictrict);

        }

        public class Student
        {
            private int id;
            private string name;
            private double cgpa;
            private string bloodGroup;
            private AddressFromat address;

            public int Id
            {
                get { return this.id; }
                set { this.id = value; }
            }
            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public double Cgpa
            {
                get { return this.cgpa; }
                set
                {
                    if (value >= 0.0 && value <= 4.0)
                    {
                        this.cgpa = value;
                    }
                    else
                    {
                        this.cgpa = -1;

                    }
                }

            }
            public string BloodGroup
            {
                get { return this.bloodGroup; }
                set { this.bloodGroup = value; }
            }
            public AddressFromat Address
            {
                get { return this.address; }
                set { this.address = value; }
            }
            public int GetId()
            {
                return this.id;
            }
            public void SetId(int id)
            {
                this.id = id;
            }
            public string GetName()
            {
                return this.name;
            }
            public void SetName(string name)
            {
                this.name = name;
            }

            public double GetCgpa()
            {
                return this.cgpa;

            }
            public void SetCgpa(double cgpa)
            {
                if (this.cgpa >= 0.0 && cgpa <= 4.0)
                    this.cgpa = cgpa;
                else
                    this.cgpa = -1;
            }
            public string GetBloodGroup()
            {
                return this.bloodGroup;
            }
            public void SetBloodGroup(string bloodGroup)
            {
                this.bloodGroup = bloodGroup;
            }

            public AddressFromat GetAddress()
            {
                return this.address;

            }
            public void SetAddress(AddressFromat address)
            {
                this.address = address;
            }
            public Student()
            {

            }
            public Student(int id, string name, double cgpa, string bloodGroup, AddressFromat address
                )

            {
                this.id = id;
                this.name = name;
                this.cgpa = cgpa;
                this.bloodGroup = bloodGroup;
                this.address = address;

            }
            private string FindGradeLetter()
            {
                if (this.Cgpa >= 3.5 && this.Cgpa <= 4.0)
                    return "Grade letter : A+";
                else if (this.Cgpa >= 3.0 && this.Cgpa <= 3.5)
                    return "Grade letter : A";
                else if (this.Cgpa == -1)
                    return "Grade Letter : Invalid";
                else
                    return "Grade Letter : F";
            }
            public void PrintStudentInfo()
            {
                Console.WriteLine("student's ID: {0}" + this.Id);
                Console.WriteLine("Student's Name:{0}" + this.Name);
                Console.WriteLine("Student's CGPA:{0}" + this.Cgpa);
                Console.WriteLine("{0}", this.FindGradeLetter());
                Console.WriteLine("Student's Blood Group: {0}", this.bloodGroup);
                this.address.printAddress();


            }



            
               

        }




    }
}
