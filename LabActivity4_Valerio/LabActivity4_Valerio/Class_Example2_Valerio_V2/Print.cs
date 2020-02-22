using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example2_Valerio_V2
{
    class Print
    {
        private string AcceptDetails, AcceptDetails2;
        public Print(string AcceptDetails, string AcceptDetails2)
        {
            this.AcceptDetails = AcceptDetails;
            this.AcceptDetails2 = AcceptDetails2;
        }
        public string Describe()
        {


            return "Hello " + AcceptDetails + " " + AcceptDetails2 + "!!!\nYou have created classes in OOP";


        }
    }
}
