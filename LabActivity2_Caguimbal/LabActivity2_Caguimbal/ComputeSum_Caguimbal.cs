using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabActivity2_Caguimbal
{
    class ComputeSum_Caguimbal
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum = {0} ", num1 + num2);
            Console.ReadLine();
        }
    }
}
