using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2._2_Capuli
{
    class Accept
    {
        public string color1, color2;
        public void AcceptDetails()
        {
            System.Console.Write("Enter Car1 Color:\t");
            color1 = System.Console.ReadLine();
            System.Console.Write("Enter Car2 Color:\t");
            color2 = System.Console.ReadLine();
        }
    }
}
