using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1_MillerV2
{
    class Print
    {
        private string fname, lname;
        public Print(string fname, string lname)
        {
            this.fname = fname;
            this.lname = lname;            
                        
        }
        public void Describe()
         {
             Console.WriteLine( "Hello " + fname + " " + lname + "!!!\nYou have created classes in OOP");
         }
    }
}
