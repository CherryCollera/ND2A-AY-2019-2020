using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_MillerV2
{
    class Car
    {
        
            private string color;
            public Car(String color)
            {
                this.color = color;
                
            }
            public string Describe()
            {
                return "This car is " + color;
            }
        

    }
}
