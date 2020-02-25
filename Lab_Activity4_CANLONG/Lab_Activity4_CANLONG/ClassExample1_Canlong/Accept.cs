using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClassExample1_Canlong;
namespace ClassExample1_Canlong
{
    class Accept
    {
        public string firstname, lastname;
        public void AcceptDetails()
        {
            System.Console.Write("Enter your Firstname and Lastname:\t");
            firstname = System.Console.ReadLine();
            lastname = System.Console.ReadLine();
        }

    }
}
 
