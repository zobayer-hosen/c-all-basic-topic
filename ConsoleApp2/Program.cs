using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public int paramskEY(params int[] a)
        {
            int sum = 0;
            foreach( int i in a)
            {
                sum += i;
            }
            return sum;
        }
      
        static void Main(string[] args)
        {
            var a = 10000;
            Console.WriteLine(a.GetType());
            var b = a;

            object[] obj = new object[] { 1, 2.0f, 'a', "hello" };
            foreach( var i in obj)
            {
                Console.WriteLine(i);
                Console.WriteLine(i.GetType());
            }
        }
    }
}
