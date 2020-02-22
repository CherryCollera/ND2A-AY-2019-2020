using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1_MillerV2
{
    class Accept
    {
        public string firstname, lastname;
        public void AcceptDetails()
        {
            Console.Write("Enter your firstname and lastname: ");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
        }
    }
}
