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
            double grades1, grades2, grades3, grades4,grades5;

            Console.WriteLine("Enter 5 grades:");
            grades1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            grades2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            grades3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            grades4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("");
            grades5 = Convert.ToInt32(Console.ReadLine());

            double add = grades1 + grades2 + grades3 + grades4 + grades5;
            double fa = add / 5;
            Console.Write("\nThe Average is {0:0.000}", fa);

            Console.ReadLine();
        }
    }
}
