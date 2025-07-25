using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public abstract class Animal:Kingdom
    {
        public abstract void KIngdom();
        public abstract int InterfaceSum(int a, int b);

        protected int _x = 100;
        protected int _y = 150;

        public abstract int X { get; }
        public abstract int Y { get; }

        public abstract void AbstractMethod();
        //public  abstract int a { set; get; }
        //abastract method (doesnot have a body)
        public abstract void animalSound();



        public abstract int lag(int a, int b);
        //Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }

        
    }
    
}
