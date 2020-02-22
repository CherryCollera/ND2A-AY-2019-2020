using System;
using ClassExample1_Miller;

namespace ClassExample1_Miller
{
    class Print
    {
        public void PrintDetails()
        {
            Accept a = new Accept();
            a.AcceptDetails();
            Console.Write("Hello " + a.firstname + " " + a.lastname + "!!!\nYou have created classes in OOP");
            MyProfile mp = new MyProfile();
            mp.DisplayProfile();
        }
    }
}
