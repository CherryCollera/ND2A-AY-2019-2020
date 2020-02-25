using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2_Paulo
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
            return "This car is " + color;
        }
    }
}
