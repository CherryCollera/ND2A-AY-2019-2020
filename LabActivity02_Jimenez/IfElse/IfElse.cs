﻿using System;
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
            Console.Write("Enter first number:\t  ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number:\t  ");
            num2 = Convert.ToInt32(Console.ReadLine());
            

            if (num1 > num2)
                Console.WriteLine(num1 + " is Greater Than to " + num2);
            else if (num2 > num1)
                Console.WriteLine(num2 + " is Greater Than to " + num1);
            else 
                Console.WriteLine(num1 + " is Equal to " + num2);
            Console.ReadKey();

        }
    }
}
