using System;

namespace IfElse
{
    class IfElse
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: \t");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: \t");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            if (num1>num2)
                Console.Write(num1 +" is greater than "+num2);
            else if(num1<num2)
                Console.Write(num1+" is less than "+num2);
            else
                Console.Write(num1+" is equal "+num2);
            Console.ReadKey();
        }
    }
}
