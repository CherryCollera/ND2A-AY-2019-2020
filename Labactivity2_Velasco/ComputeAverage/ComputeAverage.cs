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
            int num1, num2, num3, num4, num5, num6;
            Console.Write("Enter 5 grades: ");
            Console.WriteLine(" ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());
            num6 = num1 + num2 + num3 + num4 + num5;
            Console.Write("The average is = {0:0.000}  ", num6 / 5.000);
            Console.ReadLine();
        }
    }
}
