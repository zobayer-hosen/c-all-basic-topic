using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @params
{
    class Program
    {
        public string Concatinaing(params string[] words)
        {
            return string.Join(" " + words);
        }

        //this is not a params function
        public static int suM(int a , int b, int c)
        {
            return a + b + c;
        }
        public static int addition(params int[] element)
        {
            int a = 0;
            foreach(int sum in element)
            {
                a = a + sum;
            }
            return a;
        }
        static void Main(string[] args)
        {
            Program a = new Program();
            Console.WriteLine(a.Concatinaing("hello", "my name is","zobayer"));
            Console.WriteLine(suM(10, 20, 30));

            Console.WriteLine(addition(20, 33, 444, 5));


        }
    }
}
