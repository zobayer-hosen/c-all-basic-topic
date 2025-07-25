using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_session
{
    class Complex
    {
        public enum Shapes
        {
            Circle,
            Square
        }
        public void peri(int val,Shapes shape)
        {
            if (shape == Shapes.Circle)
            {
                Console.WriteLine("Circumference of the circule is" + 2 * 3.1416 * val);
            }
            else
            {
                Console.WriteLine("perimeter of the aquare is" + 4 * val);
            }
        }

    }
}
