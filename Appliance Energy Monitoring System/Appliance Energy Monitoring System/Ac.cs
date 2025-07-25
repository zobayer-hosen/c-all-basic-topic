using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_Energy_Monitoring_System
{
    class Ac:Appliance
    {
        private int btu;
        private int starRating;


        public int Btu
        {
            get { return this.btu; }
            set { this.btu = value; }
        }
        public int StarRating
        {
            get { return this.StarRating; }
            set { this.StarRating = value; }
        }

        public Ac() : base()
        {

        }
        public Ac(string applianceName,string brand ,int btu,int starRating) : base(applianceName, brand)
        {
            this.btu = btu;
            this.starRating = starRating;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("the btu " + this.btu);
            Console.WriteLine("the star Rating " + this.starRating);
        }
        public double MonthlyElectricityCost(int hours)
        {
            return btu * hours * 0.05; 
        }
        public double MonthlyElectricityCost(int hours, double unitCost)
        {
            double cost = btu * hours * unitCost;
            totalEnergyUsed += cost;
            return cost;
        }

        public bool IsEcoFriendly()
        {
            if (starRating>= 4)
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
