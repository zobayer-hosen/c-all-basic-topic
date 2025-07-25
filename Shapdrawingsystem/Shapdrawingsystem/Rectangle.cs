using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Shapdrawingsystem
{
    class Rectangle:Shap
    {
        private double length;
        private double width;


        public double Length
        {
            get { return this.length; }
            set { this.width = value; }
        }
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }

        }

        public Rectangle():base()
        {

        }
        public Rectangle(string shapName, string shapType,double length,double width):base(shapName,shapType)
        {
            this.length = length;
            this.width = width;

        }
        
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("the length is" + this.length);
            Console.WriteLine("the width is" + this.width);
        }
        public bool IsSquare()
        {
            if(this.length == this.width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetPerimeter()
        {
            return 2 * (this.length + this.width);
        }
        public string GetPerimeter(string unit)
        {
            return GetPerimeter().ToString() +" "+ unit;
        }
             



    }
}
