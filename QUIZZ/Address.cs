using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZZ
{
   public class Address
    {
        private string name;
        private int localaddress;
        private int post;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Localaddress
        {
            get { return this.localaddress; }
            set { this.localaddress = value; }
        }
        public int Post
        {
            get { return this.post; }
            set { this.post = value; }
        }
        public Address()
        {

        }
        public Address(string name,int localaddress, int post)
        {
            this.name = name;
            this.localaddress = localaddress;
            this.post = post;
        }
        public void  showdetils( )
        {
            Console.WriteLine();
            Console.WriteLine(this.name);
            Console.WriteLine(this.localaddress);
            Console.WriteLine(this.post);

        }
        

       
    }
}
