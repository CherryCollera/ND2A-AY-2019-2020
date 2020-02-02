using System;

namespace BasicOperations
{
    class BasicOperations
    {
        static void Main()
        {
            int num1, num2;
            Console.Write("Enter first number:   ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum= {0}.    ", num1 + num2);
            Console.WriteLine("Difference= {0}.    ", num1 - num2);
            Console.WriteLine("Product= {0}.    ", num1 * num2);
            Console.WriteLine("Quotientt= {0}.    ", num1 / num2);
            Console.WriteLine("Remainder= {0}.    ", num1 % num2);
            Console.ReadKey();

        }
    }
}