using System;

namespace BasicOperations
{
    class BasicOperations
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nSum = {0} ", (num1 + num2));
            Console.WriteLine("Difference = {0} ", (num1 - num2));
            Console.WriteLine("Product = {0} ", (num1 * num2));
            Console.WriteLine("Quotient = {0} ", (num1 / num2));
            Console.WriteLine("Remainder = {0} ", (num1 % num2));
            Console.ReadLine();
        }
    }
}
