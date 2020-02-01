using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    class BasicOperation
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n Sum= {0} ", num1 + num2 + "\n");
            Console.Write("Difference= {0} ", num1 - num2 +"\n");
            Console.Write("Product= {0} ", num1 * num2 + "\n");
            Console.Write("Quotient= {0} ", num1 / num2 + "\n");
            Console.Write("Remainder= {0} ", num1 % num2 + "\n");
            Console.ReadLine();
        }
    }
}
