using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Cat();
            Console.WriteLine(a.lag(2, 4));
            a.animalSound();
            a.sleep();
            Console.WriteLine(a.X + "  " + a.Y);

            Console.WriteLine(a.InterfaceSum(10, 2));
            a.KIngdom();

            
           
        }
    }
}
