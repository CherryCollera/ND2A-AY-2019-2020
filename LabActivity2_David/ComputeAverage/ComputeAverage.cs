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
            double g1, g2, g3, g4, g5;

            Console.WriteLine("Enter 5 Grades:\t ");
            g1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t ");
            g2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t ");
            g3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t ");
            g4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\t ");
            g5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Total Average is = {0}", (g1 + g2 + g3 + g4 + g5) / 5);
            Console.ReadLine();
        }
    }
}
