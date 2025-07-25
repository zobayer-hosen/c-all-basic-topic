using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterFace_class
{
    class Program
    {
        /// <summary>
        /// interface completely abastract class which can only contain abstract methods and properties
        /// 
        /// 1.Interface cannot have private members
        /// 2.by defalit all the member of interface are public and abstruct 
        /// 3.the interface will always be defined with the help of the keyword interface 
        /// 4.interface cannot contain fields because they represent an implementaion of data 
        /// we can achieve multiple inheritance with the interface but within the classes 
        /// we can implement multiple interface in a single class sparated by commas
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// 
       interface Class1
        {
            void Sum(int a, int b);

        }
        interface Class2
        {
            void Multiple(int c, float d);
        }
        interface Class3
        {
            void Division(int e, double f);
        }
        public class Calculator : Class1, Class2, Class3
        {
            public void Sum( int a, int b)
            {
                int sum = a + b;
                Console.WriteLine("the sum is " + sum);
            }
            public void  Multiple(int c ,float d)
            {
                float multiple = c + d;
                Console.WriteLine("the multiple number is " + multiple);

            }
            public void Division(int e ,double f)
            {
                double division = e % f;
                Console.WriteLine("the number of division is " + division);
            }

                


        }


        static void Main(string[] args)
        {
            Calculator a = new Calculator();
            a.Sum(2, 4);
            Class1 b = new Calculator();
            b.Sum(4, 5);
            
        }
    }
}
