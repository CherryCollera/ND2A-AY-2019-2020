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

            Console.Write("Enter First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
                Console.Write("{0} is greater than {1}", num1, num2);
            else if (num1 < num2) 
            Console.Write("{1} is greater than {0}", num1, num2);
            else 
            Console.Write("{0} is equal {1}", num1, num2);
            Console.ReadLine();
        }
    }
}
