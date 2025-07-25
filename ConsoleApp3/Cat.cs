using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Cat:Animal
    {
        public override int InterfaceSum(int a, int b)
        {
            return a + b;
        }
        public override void KIngdom()
        {
            Console.WriteLine("the kindom is here");
        }
        public override void AbstractMethod()
        {
            _x++;
            _y++;

        }
        public override int X
        {
            get
            {
                return _x + 10;
            }
        }
        public override int Y
        {
            get
            {
                return _y + 11;
            }
        }
        //public  override int a=>10;

        public override int lag(int a, int b)
        {
            return a + b;
        }

        public override void animalSound()
        {
            Console.WriteLine("the animal sound like mewo");
        }

        public void sleep()
        {
            Console.WriteLine("the cat is sleeping");
        }

    }
}
