using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettype__var_and_dynamic
{
    class Program
    {// object.gettype method is used to find the type of the current instance .
        //this method returns the instance of the type class that are used for consideration
        

        static void Main(string[] args)
        {
            var a = 10000;
            Console.WriteLine(a.GetType());
            var b = a;

            object[] obj = new object[] { 1, 2.0f, 'a', "hello" };
            foreach(var i in obj)
            {
                Console.WriteLine(i);
                Console.WriteLine(a.GetType());
            }
        }
    }
}
