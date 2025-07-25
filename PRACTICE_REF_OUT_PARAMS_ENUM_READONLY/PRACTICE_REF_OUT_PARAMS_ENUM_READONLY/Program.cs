using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_REF_OUT_PARAMS_ENUM_READONLY
{
    class Program
    {
        public readonly int a = 10;

        public readonly int b;
        public readonly int c;
        public Program(int a, int b)
        {
            this.b = a;
            this.c = b;
            Console.WriteLine("the first number is " + b + " and the second number is  " + c);




        }


        public static int paramskey(params int[] words)
        {
            int sum = 0;
            foreach(int word in words)
            {
                sum = sum + word;
            }
            return sum;
        }
        public static void OutKeyword( out int a ,out int b)
        {
            a  = 40;
            b = 30;
            a += a;
            b += b;

           
        }
        public static void refMethod(ref int a, ref int b)
        {
            a += 10;
            b += 20;
        }
        static void Main(string[] args)
        {
            int c = 10;
            int d = 20;
            refMethod(ref c, ref d);
            Console.WriteLine("the value of a c" + c);
            Console.WriteLine("the value of a  d" + d);

            Complexref a = new Complexref(4, 5);
            Console.WriteLine(a.Getreal()+ "+   i" + a.Getimag());
            Complexref.Reffenecce(ref a);
            Console.WriteLine("After updating C");
            Console.WriteLine("Complex number C = " + a.Getreal() +
                                             " + i " + a.Getimag());

            int e,f;
            OutKeyword(out e, out f);
            Console.WriteLine("the out key word is" + e);
            Console.WriteLine("the out key word is " + f);


           Console.WriteLine( paramskey(10, 20, 40, 50));


            Program s = new Program(10, 20);


        }
    }
}
