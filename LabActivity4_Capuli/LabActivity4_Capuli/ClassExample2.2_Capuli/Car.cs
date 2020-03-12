using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2._2_Capuli
{
    class Car
    {
        private string color1, color2;
        public Car(string color1, string color2)
        {
            this.color1 = color1;
            this.color2 = color2;
        }
        public string Describe()
        {
            return "This car is " + color1;

        }
        public string Describe2()
        {
            return "This car is " + color2;

        }
    }
}
