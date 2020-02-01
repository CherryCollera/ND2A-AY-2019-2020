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
            double radius;
            

            Console.Write("Enter Radius: ");
            radius = Convert.ToInt32(Console.ReadLine());

            double area = pi * radius * radius;
            Console.Write("Radius: {0:0.0000}", radius);
            Console.Write("\tArea: {0:00.0000}", area);

            Console.ReadLine();
        }
    }
}
