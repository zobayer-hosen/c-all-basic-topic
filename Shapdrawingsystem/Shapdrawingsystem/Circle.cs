using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapdrawingsystem
{
    class Circle:Shap
    {
        private double radius;
        private string color;

        public double Radius
        {
            get { return this.Radius; }
            set { this.Radius = value; }
        }
        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public Circle():base()
        {

        }
        public Circle(string shapeName, string shapeType, double radius, string color) : base(shapeName, shapeType)
        {
            this.radius = radius;
            this.color = color;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("Circule radius " + this.radius);
            Console.WriteLine("Circule Color" + this.color);
        }
        public double GetDiameter()
        {
            return this.radius * 2;
        }
        public bool IsLargeCircule()
        {
            if (radius > 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }




    }
}
