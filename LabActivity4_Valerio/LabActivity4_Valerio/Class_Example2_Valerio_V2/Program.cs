using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Example2_Valerio_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            Accept a = new Accept();
            a.AcceptDetails();

            Print AcceptDetails;
            AcceptDetails = new Print(a.firstname, a.lastname);

            Console.WriteLine(AcceptDetails.Describe());

            MyProfile mp = new MyProfile();
            mp.DisplayProfile();

            Console.ReadLine();


        }
    }
}
