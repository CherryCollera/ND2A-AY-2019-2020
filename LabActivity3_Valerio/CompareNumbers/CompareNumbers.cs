using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNumbers
{
    class CompareNumbers
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter 1st number ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3))
            {
                Console.WriteLine(num1 + " is greater than " + num2 + " and " + num3);

                if (num2 > num3)
                {
                    Console.WriteLine(num2 + " is less than " + num1);
                    Console.WriteLine(num3 + " is less than " + num1);
                }
                else if (num1 < num3)
                {
                    Console.WriteLine(num3 + " is less than " + num1);
                    Console.WriteLine(num2 + " is less than " + num1);
                }
                else
                    Console.WriteLine(num2 + " and " + num3 + " are equals");
            }
            else if ((num2 > num1) && (num2 > num3))
            {
                Console.WriteLine(num2 + " is greater than " + num1 + " and " + num3);

                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " is less than " + num2);
                    Console.WriteLine(num3 + " is less than " + num2);
                }
                else if (num2 < num3)
                {
                    Console.WriteLine(num3 + " is less than " + num2);
                    Console.WriteLine(num1 + " is less than " + num2);
                }
                else
                    Console.WriteLine(num1 + " and " + num3 + " are equals");
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                Console.WriteLine(num3 + " is greater than " + num1 + " and " + num2);

                if (num1 > num2)
                {
                    Console.WriteLine(num1 + " is less than " + num3);
                    Console.WriteLine(num2 + " is less than " + num3);
                }
                else if (num3 < num2)
                {
                    Console.WriteLine(num2 + " is less than " + num3);
                    Console.WriteLine(num1 + " is less than " + num3);
                }
                else
                    Console.WriteLine(num1 + " and " + num2 + " are equals");

            }
           else 
       {
                Console.WriteLine(num1 + " " + num2 + " and " + num3 + " are equal");
            }
            Console.ReadKey();
        }
    }
}