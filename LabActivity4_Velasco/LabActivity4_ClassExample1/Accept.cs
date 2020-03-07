using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity4_ClassExample1
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
