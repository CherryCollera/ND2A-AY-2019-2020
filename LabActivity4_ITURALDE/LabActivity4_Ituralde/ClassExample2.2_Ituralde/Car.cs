using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2._2_Ituralde
{
    class Car
    {
        private string col1, col2;
        public Car(string col1, string col2)
        {
            this.col1 = col1;
            this.col2 = col2;
        }
        public string Describe()
        {
            return "This car is " + col1;

        }
        public string Describe2()
        {
            return "This car is " + col2;

        }
    }
}
