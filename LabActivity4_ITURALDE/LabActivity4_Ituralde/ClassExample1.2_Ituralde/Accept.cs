using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1._2_Ituralde
{
    class Accept
    {
        public static string firstname, lastname;
        public void AcceptDetails()
        {
            System.Console.Write("Enter your firstname and lastname:\t");
            firstname = System.Console.ReadLine();
            lastname = System.Console.ReadLine();
        }
    }
}
