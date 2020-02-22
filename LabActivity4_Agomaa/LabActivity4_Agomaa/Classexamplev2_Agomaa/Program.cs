using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classexmaple1v2_Agomaa
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
            mp.DisplayMyProfile();

            Console.ReadLine();
        }
    }
}
