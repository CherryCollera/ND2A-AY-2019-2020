using System;
namespace Classexample2v2
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
            return "\nThis car is " + AcceptColor2;
        }
    }
        class thecolor
        {
            public string color1, color2;
            public void AcceptColor()
            {
                System.Console.Write(" Enter Color 1: \t\t");
                color1 =Console.ReadLine();

                System.Console.Write(" Enter Color 2: \t\t");
                color2 =Console.ReadLine();
            }

        }
    
}
