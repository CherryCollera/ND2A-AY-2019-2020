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
            double g1,g2,g3,g4,g5;

            Console.Write("Enter 5 grades:" + "\n");
            g1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            g2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            g3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            g4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            g5 = Convert.ToInt32(Console.ReadLine());

            double Sum = g1 + g2 + g3 + g4 + g5;
            double Ave = Sum / 5;
            Console.Write("The Average is {0:0.00}   ",  Ave );
            Console.ReadLine();

        }
    }
}
