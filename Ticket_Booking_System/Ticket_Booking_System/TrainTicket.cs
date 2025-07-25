using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System
{
    class TrainTicket:Ticket
    {
        private string coachType;
        private double fare;

        public string CoachType
        {
            get { return this.coachType; }
            set { this.coachType = value; }
        }
        public double Fare
        {
            get { return this.fare; }
            set { this.fare = value; }
        }
        public TrainTicket()
        {

        }
        public TrainTicket(int ticketId, string passengerName,string coachType,double fare) : base(ticketId, passengerName)
        {
            this.coachType = coachType;
            this.fare = fare;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("passenger Coach type" + this.coachType);
            Console.WriteLine("passenger fare" + this.fare);

        }
        public bool IsACCoach()
        {
            if(coachType == "AC")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GetTaxAmount()
        {
            return fare * 0.01;
        }
    }
}
