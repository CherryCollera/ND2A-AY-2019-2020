using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1_MillerV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Accept a = new Accept();
            a.AcceptDetails();
            Print p = new Print(a.firstname,a.lastname);
            p.Describe();
            MyProfile mp = new MyProfile();
            mp.DisplayProfile();
            Console.ReadLine();
        }
    }
}
