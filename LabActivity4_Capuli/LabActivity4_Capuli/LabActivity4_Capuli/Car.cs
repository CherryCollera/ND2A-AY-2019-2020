using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity4_Capuli
{
    class Car
    {
        private string FColor, SColor;
        public Car(string FColor, string SColor)
        {
            this.FColor = FColor;
            this.SColor = SColor;
        }
        public string Describe()
        {
            return "This car is " + FColor;

        }
        public string Describe2()
        {
            return "This car is " + SColor;

        }
    }
}
