using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstant
{
    class DeclaringConstant
    {
        static void Main(string[] args)
        {

            const double pi = 3.14159;
            double radius;

            Console.Write("Enter Raduis:");
            radius = Convert.ToInt32(Console.ReadLine());

            double area = pi * radius * radius;
            Console.Write("Radius: {0:0.0000} ",radius);
            Console.Write("Area: {0:00.0000} " , area);
            Console.ReadLine();
        }
    }
}
