using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2._2_Ituralde
{
    class Accept
    {
        public string col1, col2;
        public void AcceptDetails()
        {
            System.Console.Write("Enter Car1 Color:\t");
            col1 = System.Console.ReadLine();
            System.Console.Write("Enter Car2 Color:\t");
            col2 = System.Console.ReadLine();
        }
    }
}
