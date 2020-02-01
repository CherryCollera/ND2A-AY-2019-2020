using System;

namespace ComputeSum
{
    class ComputeSum
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sum = {0} ", (num1 + num2));
            Console.ReadLine();
        }
    }
}
