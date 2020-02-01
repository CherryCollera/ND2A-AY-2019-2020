using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double rad;
            Console.Write("Enter Radius: ");
            rad = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("Radius: {0:0.0000},", rad );
            double AreaCircle = pi * rad * rad;
            Console.Write(" Area: {0:0.0000} ", AreaCircle);
            Console.ReadKey();

        }
    }
}
