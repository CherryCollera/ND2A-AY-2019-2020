using System;

namespace IfElse
{
    class IfElse
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine(num1 + "is Greater than" + num2);
            else if (num1 == num2)
                Console.WriteLine(num1 + "is Greater than" + num2);
            else
                Console.WriteLine(num1 + "is Less than" + num2);
            Console.ReadKey();
        }
    }
}