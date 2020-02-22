using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexample1v2
{
    class Accept
    {
        public string firstname, lastname;
        public void AcceptDetails()
        {
            System.Console.Write("Enter Your Firstname and Lastname:\t");
            firstname = System.Console.ReadLine();
            lastname = System.Console.ReadLine();

        }
    }
}
