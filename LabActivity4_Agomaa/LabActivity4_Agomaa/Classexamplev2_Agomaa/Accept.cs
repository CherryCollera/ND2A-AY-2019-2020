using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexamplev2_Agomaa
{
    class Accept
    {

            public string firstname, lastname;
            public void AcceptDetails()
            {
                System.Console.Write("Enter Your Firstbane and Lastname:\t");
                firstname = System.Console.ReadLine();
                lastname = System.Console.ReadLine();
            }
    }

}

