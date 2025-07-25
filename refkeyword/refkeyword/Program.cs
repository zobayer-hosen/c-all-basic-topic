using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace refkeyword
{
    class Program
    {

        static void summehtod(ref int  b, ref float c)
        {
            b += 10;
            c += 15;
        }
        static void Updatemessage(ref string message)
        {
            message += " updated by ref!";
        }

        static void Addfive( ref int number)
        {
            number = number + 5;
        }
        static void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        static void mymethod(ref int number)
        {
            number *= 2;

        }
        static void Main(string[] args)
        {
            int d = 10;
            float f = 20f;
            summehtod(ref d, ref f);
            Console.WriteLine(d);
            Console.WriteLine(f);
            string mag = "Orginal";
            Updatemessage(ref mag);
            Console.WriteLine(mag);
            int myNumber = 10;
            Addfive(ref myNumber);
            Console.WriteLine(myNumber);

            int x = 5, y = 10;
            swap(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            int num = 6;
            mymethod(ref num);
            Console.WriteLine("the number is " + num);

        }
    }
}
