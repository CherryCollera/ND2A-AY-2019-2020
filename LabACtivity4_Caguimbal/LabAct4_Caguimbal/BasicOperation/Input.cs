using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    class Input
    {
        public static int num1, num2;

        public int number1()
        {
            Console.Write("Enter number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            return num1;
        }
        public int number2()
        {
            Console.Write("Enter number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            return num2;
        }
    }
}
