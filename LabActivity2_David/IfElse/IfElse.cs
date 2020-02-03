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
            Console.Write("Enter first number:  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:  ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.WriteLine(num1 + " is Greater than to " + num2);
            else if (num1 < num2)
                Console.WriteLine(num1 + " is Less than to " + num2);
            else
                Console.WriteLine(num1 + " is Equal to " + num2);
            Console.ReadKey();

        }
    }
}
