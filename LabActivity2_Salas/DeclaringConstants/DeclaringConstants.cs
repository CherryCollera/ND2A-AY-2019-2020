using System;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main(string[] args)
        { 
            double radius;
            double pi = 3.14159;
            Console.Write("Enter Radius:  ");
            radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Radius: {0:0.0}", radius);
            Console.Write("\tArea: {0:0.0}", pi * radius * radius);
            Console.ReadKey();

        }
    }
}
