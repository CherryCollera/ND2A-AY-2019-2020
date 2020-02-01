using System;

namespace DeclaringConstant
{
    class declaringConstant
    {
        static void Main(string[] args)
        {
            int radius;
            const double pi = 3.14159;
            Console.Write("Enter radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
            Console.Write("Radius: {0:0.0000} ",radius);
            Console.WriteLine("\tArea: {0:0.0000} ",pi*radius*radius);
            Console.ReadLine();
        }
    }
}
