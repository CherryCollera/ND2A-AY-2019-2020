using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample2_Ver2
{
    class Car
    {
        private string AcceptColor, AcceptColor2;

        public Car(string AcceptColor, string AcceptColor2)
        {
            this.AcceptColor = AcceptColor;
            this.AcceptColor2 = AcceptColor2;

        }
        public string Describe()
        {
            return "\nThis car is " + AcceptColor;
        }
        public string Describes()
        {
            return "This car is " + AcceptColor2;
        }
    }

    class thecolor
    {
        public String color1, color2;
        public void AcceptColor()

        {
            System.Console.WriteLine("ENTER COLOR 1:");
            color1 = Console.ReadLine();

            System.Console.WriteLine("ENTER COLOR 2:");
            color2 = Console.ReadLine();
        }
    }
}
