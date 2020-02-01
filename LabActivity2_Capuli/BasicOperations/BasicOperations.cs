using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations
{
    class BasicOperations
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nSum = {0}.\n", num1 + num2);
            Console.Write("Difference = {0}.\n", num1 - num2);
            Console.Write("Product = {0}.\n", num1 * num2);
            Console.Write("Quotient = {0}.\n", num1 / num2);
            Console.Write("Remainder = {0}.\n", num1 % num2);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
