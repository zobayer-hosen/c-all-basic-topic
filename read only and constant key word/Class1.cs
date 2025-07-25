using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_only_and_constant_key_word
{
    class Class1
    {
        public virtual void show()
        {
            Console.WriteLine("Display dimension 6*6");
        }
        public virtual void print()
        {
            Console.WriteLine("Printer printing...\n");
        }
    }
    class Lesterjet : Class1
    {
        public sealed override void show()
        {
            base.show();
            Console.WriteLine("Display dimension 12*12");
        }
        public override void print()
        {
            base.print();
            Console.WriteLine("Laserjet printer printing....\n");
        }

    }
    class Officejet : Lesterjet
    {
        public override void print()
        {
            base.print();
            Console.WriteLine("officejet printer printing .....");
        }
    }
}
