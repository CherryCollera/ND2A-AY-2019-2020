using System;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main()
        {
            const double pi = 3.14159;
            int r = 0;
            double a = 0;
            Console.Write("Enter the radius: ");
            r = Convert.ToInt32(Console.ReadLine());
            a = pi * r * r;
            Console.WriteLine("Radius : {0:0.0000} ", r);
            Console.WriteLine("Area : {0:0.0000} ", a);
            Console.ReadLine();

        }
    }
}