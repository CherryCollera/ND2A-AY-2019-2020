using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicOperations_Jimenez
{
    class Input
    {
        public static double num, nums;
        public double number1()
        {
            System.Console.Write("Input first number: ");
            num = System.Convert.ToDouble(System.Console.ReadLine());
            return num;
        }
        public double number2()
        {
            System.Console.Write("Input Second number: ");
            nums = System.Convert.ToDouble(System.Console.ReadLine());
            return nums;
        }
    }
}


