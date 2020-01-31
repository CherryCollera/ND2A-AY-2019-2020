using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstant
{
    class DeclaringConstatnt
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double radius = 0;
   
            Console.Write("Enter Radius: \t");
            radius = Convert.ToInt32(Console.ReadLine());
            double AreaCircle = pi * radius * radius;
            Console.Write("Radius = {0:0.0000}  ", radius);
            Console.Write("Area = {0:0.0000}  ", AreaCircle);
            Console.ReadLine();
        }
    }
}
