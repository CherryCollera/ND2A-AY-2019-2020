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
            int num1;
            
            Console.WriteLine("Enter Radius:  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Radius = {0:0.0000}  ", num1);
            Console.WriteLine("Area = {0:0.0000}  ", pi*num1*num1);
            Console.ReadKey();


        }
    }
}
