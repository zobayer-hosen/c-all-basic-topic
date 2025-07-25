using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System
{
    class FlightTicket : Ticket
    {
        private string seatClass;
        private double luggageWeight;

        public string SeatClass
        {
            get { return this.seatClass; }
            set { this.SeatClass = value; }
        }
        public double LaggageWeight
        {
            get { return this.LaggageWeight; }
            set { this.LaggageWeight = value; }
        }
        public FlightTicket()
        {


        }
        public FlightTicket(int ticketId, string passengeName, string seatClass, double luggageWeight) : base(ticketId, passengeName)
        {
            this.seatClass = seatClass;
            this.luggageWeight = luggageWeight;
        }
        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine("passenger SeatClass" + this.seatClass);
            Console.WriteLine("passenger Luggage Weight" + this.luggageWeight);
        }
        public bool IsExcessLuggage()
        {
            if (luggageWeight > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsPrioritySeat()
        {
            if(seatClass == "business")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool IsPrioritySeat(bool isFrequentFlyer)
        {
            if(isFrequentFlyer is true && seatClass== "Business")
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
