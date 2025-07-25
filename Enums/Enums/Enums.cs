using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Peremeter
    {
        public enum Shapes
        {
            Circle,
            Square
        }
        //shapes enums type (like a custom data type )
        //shape function parameter of type

        public void Peri(int val , Shapes shape)
        {
            if(shape == Shapes.Circle)
            {
                Console.WriteLine("Circumference of the circule is " + 2 * 3.1416 * val);

            }
            else
            {
                Console.WriteLine("Perimeter of the square is " + 4*val);
            }
        }
    }
}
