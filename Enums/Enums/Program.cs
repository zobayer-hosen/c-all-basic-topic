using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        enum days { sun,mon,tue,wed};
        enum random { a, b=6,c,d};

        enum level
        {
            low,
            medium,
            high
              
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sum " + (int)days.sun);
            Console.WriteLine("tue " + (int)days.tue);
            Console.WriteLine("a " + (int)random.a);
            Console.WriteLine("b " + (int)random.b);
            level myvar = level.high;
            int lev = (int)level.high;
            Console.WriteLine("this is a "+ lev+ "level pizza  and thid is "+ myvar);

            switch (myvar)
            {
                case level.high:
                    Console.WriteLine("high level");
                    break;
                case level.medium:
                    Console.WriteLine("medium level");
                    break;
                case level.low:
                    Console.WriteLine("low level");
                    break;

                 




            }
            Peremeter o = new Peremeter();
            o.Peri(3, Peremeter.Shapes.Circle);
            o.Peri(4, Peremeter.Shapes.Square);
        }
    }
}
