using System;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main(string[] args)
        {
            double radius;
            const double pi = 3.14159;
            Console.Write("Enter Radius:\t");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: {0:0.0000}",radius);
            Console.Write("\tArea: {0:0.0000}", pi * radius * radius);
            Console.ReadLine();
        }
    }
}
