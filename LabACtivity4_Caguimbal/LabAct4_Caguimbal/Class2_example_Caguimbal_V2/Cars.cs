using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_example_Caguimbal_V2
{
    class Cars
    {
        private string color;

        public Cars(string color)
        {
            this.color = color;
        }
        public string Describe()
        {
            return "this car is " + color;
        }
    }
}
