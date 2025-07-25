using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Energy_Monitoring_System
{
    class Appliance
    {
        protected string applianceName;
        protected string brand;
        protected static double totalEnergyUsed;

        public string ApplianceName
        {
            get { return this.applianceName; }
            set { this.ApplianceName = value; }
        }
        public string Brand
        {
            get { return this.brand; }
            set { this.brand = value; }
        }
        public static double TotalEnergyUsed
        {
            get { return totalEnergyUsed; }
            set { totalEnergyUsed = value; }
        }
        public Appliance()
        {

        }
        public Appliance(string applianceName, string brand)
        {
            this.applianceName = applianceName;
            this.brand = brand;

        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("Appliance Name " + this.applianceName);
            Console.WriteLine("brand " + this.brand);
        }

            

    }
}
