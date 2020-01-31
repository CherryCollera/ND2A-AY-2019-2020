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
            Console.WriteLine(" ");
            Console.Write("Sum = {0}  ", num1 + num2);
            Console.WriteLine(" ");
            Console.Write("Difference = {0} ", num1 - num2);
            Console.WriteLine(" ");
            Console.Write("Product = {0}  ", num1 * num2);
            Console.WriteLine(" ");
            Console.Write("Quotient = {0}  ", num1 / num2);
            Console.WriteLine(" ");
            Console.Write("Remainder = {0}  ", num1 % num2);
            Console.ReadLine();
        }
    }
}
