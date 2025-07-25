using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Energy_Monitoring_System
{
    class Fan:Appliance
    {
        private int bladeSize;
        private int speedLevels;


        public int BladeSize
        {
            get { return this.bladeSize; }
            set { this.bladeSize = value; }
        }
        public int SpeedLevels
        {
            get { return this.speedLevels; }
            set { this.speedLevels = value; }
        }
        public Fan() : base()
        {

        }
        public Fan(string applianceName ,string brand,int bladeSize,int speedLevels) : base(applianceName, brand)
        {
            this.bladeSize = bladeSize;
            this.speedLevels = speedLevels;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("blade Size" + this.bladeSize);
            Console.WriteLine("speed Levels" + this.speedLevels);

        }
        public int MaxCoolingEfficiency()
        {
            return bladeSize * speedLevels;
        }

        public string NoiseCategory()
        {
            if (bladeSize < 10)
            {
                return "Low";
            }
            else if (bladeSize >=10 && bladeSize <=15)
            {
                return "Medium";
            }
            else
            {
                return "High";

            }

           
        }


    }
}
