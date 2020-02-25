using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample1_V2_Canlong
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
