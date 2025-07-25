using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace read_only_and_constant_key_word
{
  

    class Program
    {
        public const int d = 10;

        private readonly string id = "123";
        public readonly int a = 10;
        private readonly int b;
        public Program()
        {

        }
        public Program(int b)
        {
            this.b = b;
            Console.WriteLine("the value is the a is" + b);
        }
        public int B
        {
            get { return this.b; }
        }

        static void Main(string[] args)
        {
            Program c = new Program(22);
            Console.WriteLine(c.a);
            //readonly ar jonno obesily object create kora lagbe
            Console.WriteLine(Program.d);

            Class1 u = new Class1();
            u.show();
            u.print();
            Class1 si = new Lesterjet();
            si.show();
            si.print();

            Class1 of = new Officejet();
            of.show();
            of.print();

            
        }
    }
}
