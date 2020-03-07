using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1_Example_Caguimbal_V2
{
    class Accept
    {
        public string firstname, lastname;
        public void AcceptDetails()
        {
            System.Console.Write("Enter your firstname and lastname:\t");
            firstname = System.Console.ReadLine();
            lastname = System.Console.ReadLine();
        }
    }
}
