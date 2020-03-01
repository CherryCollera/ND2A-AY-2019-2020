using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample1_Capuli
{
    class Print
    {
        public void PrintDetails()
        {
            Accept a = new Accept();        //Creating object of 1st. class
            a.AcceptDetails();              //executing method of 1st class
            //Printing value of name variable
            System.Console.Write("Hello " + a.firstname + " " + a.lastname + "!!!\nYou have created classes in OOP");
            MyProfile mp = new MyProfile();
            mp.DisplayProfile();

        }
    }
}
