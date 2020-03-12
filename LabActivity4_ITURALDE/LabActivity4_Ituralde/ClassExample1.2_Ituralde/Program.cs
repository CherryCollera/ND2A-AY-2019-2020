using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1._2_Ituralde
{
    class Program
    {
        static void Main(string[] args)
        {
            Accept a = new Accept();
            a.AcceptDetails();
            Print p = new Print();
            p.PrintDetails();
            Console.ReadLine();
            MyProfile mp = new MyProfile();
            mp.DisplayProfile();
        }
    }
}
