using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZZ
{
    class Program
    {
        public static void refkey(ref int a ,ref int b)
        {
            a +=a;
            b += a;
        }
        public static void outkey(out int a,out int b)
        {
            a = 10;
            b = 12;
            a +=b;
            b = a + b;
        }
        public static int  paramaKey(params int[] arr)
        {
            int sum = 0;
            foreach(int a in arr)
            {
                sum += a;
            }
            
          return sum;
        }
        public enum level
        {
            low,
            medium,
            high

        }
        public enum shapes
        {
            diamod,
            circule,
            diamatrical,
            others

        }

        public static void enumss(int val, shapes a)
        {
            if( a == shapes.circule)
            {
                Console.WriteLine("the circule shape is " + 2 * 3.1416 * val);
            }
            else
            {
                Console.WriteLine("the diamond shape is " + 2 * val);
            }
        }
        static void Main(string[] args)
        {
            int c = 10, d = 11;

            refkey(ref c, ref d);
            Console.WriteLine("the value of a is " + c);
            Console.WriteLine("the value of b is" + d);

            int e, f;
            outkey(out e, out f);

            Console.WriteLine(paramaKey(10, 11, 23, 44));

            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine($"the pizza size of a{level.medium} and it it has {(int)level.medium}");

            enumss(4, shapes.circule);
            enumss(5, shapes.diamod);

            Address a = new Address("zobayer", 1234, 333);
            Address b = new Address("rakib", 123, 444);
            Address[] std = new Address[2] { a, b };
            Student s = new Student(24, 13, std);
            s.Show();


            Passport p = new Passport("zobayer", 24, "mirsharai");
            Citizen C = new Citizen("aburhat", "O+", p);
            C.Show();

        }

    }
}
