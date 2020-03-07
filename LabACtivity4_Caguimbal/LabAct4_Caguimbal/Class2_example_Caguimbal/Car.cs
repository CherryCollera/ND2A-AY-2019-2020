using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_example_Caguimbal
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
            return "this car is " + color;
        }
    }
}
