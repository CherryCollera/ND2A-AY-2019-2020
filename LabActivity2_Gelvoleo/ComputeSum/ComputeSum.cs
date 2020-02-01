using System;

namespace ComputeSum
{
    class ComputeSum
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = {0} ", num1 + num2);
            Console.ReadKey();


        }
    }
}