using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using ClassExample2_Canlong;
namespace ClassExample2_Canlong
{
    class Car
    {
        private string color;

        public Car(string color)
        {
            this.color = color;

        }
        public string Describe()
        {
            return "This car is" + color;
        }
    }
}