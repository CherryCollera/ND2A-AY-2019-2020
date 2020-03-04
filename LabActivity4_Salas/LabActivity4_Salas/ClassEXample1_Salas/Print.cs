using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassEXample1_Salas
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
