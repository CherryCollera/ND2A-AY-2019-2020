using System;

namespace IfElse
{
    class IfElse
    {
        static void Main()
        {
            int num1, num2;
            Console.Write("Enter first number:   ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
                Console.WriteLine(num1 + " is greater than " + num2);
            else if (num1 == num2)
                Console.WriteLine(num1 + " is equal to " + num2);
            else 
                Console.WriteLine(num1 + " is less than " + num2);
            Console.ReadKey();
        }
    }
}