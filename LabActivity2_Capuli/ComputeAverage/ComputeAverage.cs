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
            double grade1,grade2,grade3,grade4,grade5;
            Console.WriteLine("Enter 5 grades: ");
            grade1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            grade2= Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            grade3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            grade4 = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            grade5 = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();

            double result = (grade1 + grade2 + grade3 + grade4 + grade5) / 5;
            Console.Write("The average is {0:0.000}.", result);
            Console.ReadKey();

        }
    }
}
