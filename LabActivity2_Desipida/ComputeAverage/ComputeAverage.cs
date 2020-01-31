using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeAverage
{
    class ComputeAverage
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, num5;
            Console.WriteLine("Enter 5 Grades: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            num5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The average is = {0:0.000}  ", (num1 + num2 + num3  + num4 + num5)/5);
            Console.ReadLine();
        }
    }
}
