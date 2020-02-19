using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareNumber
{
    class CompareNumber
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;

            Console.Write("Enter First number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine(num1 + "  is Greater Than " + num2 + " and " + num3);

                if (num2 < num3)
                {
                    Console.WriteLine(num2 + " Is Less than " + num1);
                    Console.WriteLine(num3 + " is less than " + num1);
                }
                else if (num2 > num3)
                {
                    Console.WriteLine(num3 + " Is Less than " + num1);
                    Console.WriteLine(num2 + " Is Less than " + num1);
                }
                else
                {
                    Console.WriteLine("{0} and {1} Are Equal", num2, num3);
                }
            }
            if (num1 < num2 && num1 < num3)
            {
                Console.WriteLine(num1 + " Is Less than" + num2 + " and " + num3);
                if (num2 == num3)
                {
                    Console.WriteLine("{0} and {1} Are Equal", num2, num3);
                }
            }
            if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine(num2 + " is Greater Than " + num1 + " and " + num3);
                if (num1 > num3)
                {
                    Console.WriteLine(num1 + " Is Less " + num2);
                    Console.WriteLine(num3 + " is less than " + num2);
                }
                else if (num1 < num3)
                {
                    Console.WriteLine(num3 + " Is Less " + num2);
                    Console.WriteLine(num1 + " Is Less " + num2);
                }
                else
                {
                    Console.WriteLine("{0} and {1} Are Equal", num1, num3);
                }
            }
            if (num2 < num3 && num2 < num1)
            {
                Console.WriteLine(num2 + " Is Less than" + num3 + " and " + num1);
                if (num3 == num1)
                {
                    Console.WriteLine("{0} and {1} Are Equal", num3, num1);
                }
            }

            if (num3 > num2 && num3 > num1)
            {
                Console.WriteLine(num3 + " Is greater than" + num2 + " and " + num1);
                if (num2 > num1)
                {
                    Console.WriteLine(num1 + " is less than " + num3);
                    Console.WriteLine(num2 + " is less than " + num3);
                }
                else if (num2 < num1)
                {
                    Console.WriteLine(num2 + " Is Less " + num3);
                    Console.WriteLine(num1 + " Is Less " + num3);
                }
                else
                {
                    Console.WriteLine("{0} and {1} Are Equal", num2, num1);

                }
            }
            if (num3 < num1 && num3 < num1)
            {
                Console.WriteLine(num3 + " Is Less than" + num2 + " and " + num1);
                if (num2 == num1)
                {
                    Console.WriteLine("{0} and {1} Are Equal", num2, num1);
                }
            }
            if (num1 == num2 && num1 == num3 && num2 == num3)
            {
                Console.WriteLine(num1 + "," + num2 + " And " + num3 + " Are Equals ");


            }
            Console.ReadKey();
        }
    }
}
