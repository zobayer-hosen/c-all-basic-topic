using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_Booking_System
{
    class Ticket
    {
        protected int ticketId;
        protected string passengerName;
        protected static int totalBookings;

        public int TicketId
        {
            get { return this.ticketId; }
            set { this.ticketId = value; }
        }
        public string PassengerName
        {
            get { return this.passengerName; }
            set { this.passengerName = value; }
        }
        public static int TotalBooking
        {
            get { return totalBookings ; }
            set { totalBookings = value; }
        }

        public Ticket()
        {

        }
        public Ticket(int ticketId,string passengerName)
        {
            this.ticketId = ticketId;
            this.passengerName = passengerName;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("passenger ticket ID" + this.ticketId);
            Console.WriteLine("Passenger Name" + this.passengerName);
        }

    }
}
