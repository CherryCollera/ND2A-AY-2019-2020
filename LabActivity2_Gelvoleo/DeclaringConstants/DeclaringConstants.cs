using System;

namespace DeclaringConstants
{
    class DeclaringConstants
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            int radius = 0;
            double AreaCircle = 0;
            Console.Write("Enter Radius: ");
            radius = Convert.ToInt32(Console.ReadLine());
            AreaCircle = pi * radius * radius;
            Console.Write("Radius; {0:0.000}, ", radius);
            Console.Write("AreaCircle; {0:0.000}, ", AreaCircle);
            Console.ReadKey();  
                
        
         }
    }
}