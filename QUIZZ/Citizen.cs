using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZZ
{
    public class Citizen
    {
        private string postOffice;
        private string bloodgroup;
        private Passport passports { get; set; }

        public string PostOffice
        {
            get { return this.postOffice; }
            set { this.postOffice = value; }
        }
        public string Bloodgroup
        {
            get { return this.bloodgroup; }
            set { this.bloodgroup = value; }

        }
      
        public Citizen()
        {

        }
        public  Citizen(string postOffice,string bloodgroup,Passport passports)
        {
            this.postOffice = postOffice;
            this.bloodgroup = bloodgroup;
            this.passports = passports;
        }
        public void Show()
        {
            Console.WriteLine("Post Office: " + this.postOffice);
            Console.WriteLine("Blood Group: " + this.bloodgroup);

            if (this.passports != null)
            {
                this.passports.ShowDetails();
            }
        }

    }
}
