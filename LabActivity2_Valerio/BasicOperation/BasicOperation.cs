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
            Console.Write("Enter first number:\t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:\t");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = {0} ", num1 + num2);
            Console.WriteLine("Difference = {0} ", num1 - num2);
            Console.WriteLine("Product = {0} ", num1 * num2);
            Console.WriteLine("Quotient = {0} ", num1 / num2);
            Console.WriteLine("Remainder = {0} ", num1 % num2);
            Console.ReadLine();
        }
    }
}
