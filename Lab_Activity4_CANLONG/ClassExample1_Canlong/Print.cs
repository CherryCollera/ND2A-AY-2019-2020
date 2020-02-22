using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClassExample1_Canlong;
namespace ClassExample1_Canlong
{
    class Print
    {
        public void PrintDetails()
        {

            Accept a = new Accept();
            a.AcceptDetails();

            System.Console.Write("Hello " + a.firstname + " " + a.lastname + "!!!\nYou have Created Classes in OOP");

            MyProfile mp = new MyProfile();
            mp.DisplayMyProfile();

        }
    }
}
