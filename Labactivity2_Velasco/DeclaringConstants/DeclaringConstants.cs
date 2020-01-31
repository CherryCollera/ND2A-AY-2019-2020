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
            int num1;
            const double pi = 3.14159;
            Console.Write("Enter Radius: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Radius: {0:0.0000}", num1);
            Console.Write(", Area: {0:0.0000}", pi * num1 * num1);
            Console.ReadLine();
        }
    }
}
