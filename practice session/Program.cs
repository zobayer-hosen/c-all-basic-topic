using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace practice_session
{
    class Program
    {
        
        public enum day
        {
            sunday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday
        }
        public enum level
        {
            small,
            medium,
            high
        }
        public static void Enums(int size, string lev)
        {
            

        }
        
        public static string Concatinaing(params string[] words)
        {
            return string.Join(" " + words);
        }

        public static int paramskey(params int[] arrs)
        {
            int sum = 0;
            foreach(int i in arrs)
            {
                sum += i;

            }
            return sum; 
        }
        //in ref method obesily need variable initilize in main mehtod
        public static void refWord(ref int a,ref string b)
        {
            int sum = 0;
            sum += a;
            b += "hello";
        }


        //in out method obesily need intialized the method
        public static void Outkeyword(out int a,out int b)
        {
            a = 10;
            b = 12;
            a += 100;
            b += a;

           
           
        }
        static void Main(string[] args)
        {
            int a, b;
            Outkeyword(out a, out b);
            Console.WriteLine(a);
            Console.WriteLine(b);


            int c = 10;
            string d = "world";

            refWord(ref c, ref d);

            Console.WriteLine(c +"  "+ d);

            int e = 10;
            int f = 12;
            int g = 13;
            int h = 14;
            Console.WriteLine(paramskey(e, f, g, h));

            Console.WriteLine(Concatinaing("hello", "my name is zobayer"));

            level myvar = level.high;
            int lev = (int)level.medium;

            Console.WriteLine($"this is the piz {lev} and this is the level {myvar}");

            Console.WriteLine("sunday" + (int)day.sunday);
            Console.WriteLine("monday" + (int)day.monday);

            Complex w = new Complex();

            w.peri(10, Complex.Shapes.Circle);
            w.peri(12, Complex.Shapes.Square);

        }
    }
}
