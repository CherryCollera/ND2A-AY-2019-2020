﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample1v2
{
    class Print
    {
        
        private string AcceptDetails, AcceptDetails2;
        public Print(string AcceptDetails, string AcceptDetails2)
        {

            this.AcceptDetails = AcceptDetails;
            this.AcceptDetails2 = AcceptDetails2;

        }
        public string Describe()
        {
            return "Hello " + AcceptDetails + AcceptDetails2 + "!!!\nYou have created Classes in OOP";
        }

    }

}
class Declaration
{
    public string PrintDetails
    {
        get
        {
            return PrintDetails;
        }
        set
        {
            PrintDetails = value;
        }
    }
}
