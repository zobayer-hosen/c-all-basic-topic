using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace REF_OUT_PARAM
{
    class Program
    {
        //pass a argument to a method by its reference
        //to define a method signature to return of the variable
        //to declare a struct as a ref struct
        //as a local reference
        public static void Addvalue(int a)
        {
            a += 10;

        }
        public static void subtractValue (ref int b)
        {
            b -= 5;

        }

        static void DifferentValue(ref int e, ref float f)
        {
            e += 10;
            f -= 12;
        }

        static void Method(ref int a ,ref float b)
        {
            a += 10;
            b += 10;
            
        }

      
        static void Main(string[] args)
        {
            int a = 10;
            int b = 12;
            Addvalue(a);
            Console.WriteLine("Addvalue" + a);

            subtractValue(ref b);
            Console.WriteLine(b);

            int c = 10;
            float d = 12;

            DifferentValue(ref c, ref d);
            Console.WriteLine(c+ " and "+ d);

            int e = 10;
            float f = 11;

            Method(ref e, ref f);

            Console.WriteLine(e + " and " + f);




        }
    }
}
