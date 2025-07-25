using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapdrawingsystem
{
    public class Shap
    {
        protected string shapName;
        protected string shapType;
        protected static int totalShapes;

        public string ShapName
        {
            get { return this.shapName; }
            set { this.shapName = value; }

        }
        public string ShapType
        {
            get { return this.shapType; }
            set { this.shapType = value; }

        }
        public static int TotalShapes
        {
            get { return totalShapes; }
            set { totalShapes = value; }
        }

        public Shap()
        {

        }
        public Shap(string shapName,string shapType)
        {
            this.shapName = shapName;
            this.shapType = shapType;
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("The shap name is" + this.shapName);
            Console.WriteLine("The shap type is " + this.shapType);
        }
    }
}
