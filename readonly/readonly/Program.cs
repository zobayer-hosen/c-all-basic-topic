using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @readonly
{
    class Program
    {
        //this is the one way
        public readonly int a = 10;

        //another way constructor
        public readonly int d ;
        public Program(int d)
        {
            this.d = d;
        }



        static void Main(string[] args)
        {
            //readonly ar modome amra sudu read korte pari not a write ,,
            //two way to define readonly modifier  1.vaiable inisitize and constructor

            //Program b = new Program();
         
            //Console.WriteLine(b.a);
            Program c = new Program(2);
            Console.WriteLine(c.d);
           

        }
    }
}
