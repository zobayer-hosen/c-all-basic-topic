using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outkey_word
{
    class Program
    {
        /// <summary>
        /// but out parameter doesnot require the variables to be initialized before it passed to the method.
        /// 
        /// but out parameter doesnot require the variables to be initialized before it passed to the method.
        /// but it returns a value to the calling method the variable must be initialized in the called mehtod
        /// 
        /// 
        /// Declaration to initialize
        /// no need to initialize 
        /// the variable here data_Type variable_name ;
        /// mehtod _name(out vaiable name);
        /// you can also convert both above two
        /// method_name(out data_type variable_nem)
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// 


        public static void Addition(out int i)
        {
            i = 30;
            i += i;
        }
        public static void Addition( out int p, out int q)
        {
            p = 30;
            q = 40;
            p += q;
            q += q;

        }
        public static void Area(out int f, out int g, out int area)
        {
            f = 10;
            g = 40;
            area =  f* g;
        }
        static void Main(string[] args)
        {
            int i;
            Addition(out i);
            Console.WriteLine("the additional of the value is :" + i);

            int p, q;
            Addition(out p, out q);
            Console.WriteLine(p + "and " + q);

            Area(out int f, out int g, out int area);
            Console.WriteLine("the number of f is " + f);
            Console.WriteLine("the number of g is " + g);
            Console.WriteLine("the number of area is" + area);




        }

    }
}
