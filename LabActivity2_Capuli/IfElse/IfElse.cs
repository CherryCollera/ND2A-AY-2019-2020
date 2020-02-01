using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse
{
    class IfElse
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.Write("\n{0} is greater than {1}. ", num1,num2); 
                else if(num1 < num2)
                    Console.Write("\n{1} is greater than {0}. ", num1, num2);
                else
                    Console.Write("\n{0} is equal to {1}. ", num1, num2);
            Console.ReadKey();

        }
    }
}
