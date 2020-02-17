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

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("{0} is greater than {1} and {2}", num1, num2, num3);
                if (num2 < num3)
                {
                    Console.WriteLine("{0} is less than {1}", num2, num1);
                    Console.WriteLine("{0} is less than {1}", num3, num1);
                }
                else if (num3 < num2)
                {
                    Console.WriteLine("{0} is less than {1}", num3, num1);
                    Console.WriteLine("{0} is less than {1}", num2, num1);
                }

                else
                {
                    Console.WriteLine("{0} and {1} are equal", num2, num3);
                }
            }
            else
            {
                Console.WriteLine("{0} , {1} and {2} are equal", num1, num2, num3);
            }

            if (num2 > num1 && num2 > num3) //For 2nd greatest number
            {
                Console.WriteLine("{0} is greater than {1} and {2}", num2, num1, num3);

                if (num1 < num3)
                {
                    Console.WriteLine("{0} is less than {1}", num1, num2);
                    Console.WriteLine("{0} is less than {1}", num3, num2);
                }
                else if (num3 < num1)
                {
                    Console.WriteLine("{0} is less than {1}", num3, num2);
                    Console.WriteLine("{0} is less than {1}", num1, num2);
                }
                else
                {
                    Console.WriteLine("{0} and {1} are equal", num1, num3);
                }
            }
            if (num3 > num1 && num3 > num2) //For 3rd greatest number
            {
                Console.WriteLine("{0} is greater than {1} and {2}", num3, num1, num2);

                if (num1 < num2)
                {
                    Console.WriteLine("{0} is less than {1}", num1, num3);
                    Console.WriteLine("{0} is less than {1}", num2, num3);
                }
                else if (num2 < num1)
                {
                    Console.WriteLine("{0} is less than {1}", num2, num3);
                    Console.WriteLine("{0} is less than {1}", num1, num3);
                }
                else
                {
                    Console.WriteLine("{0} and {1} are equal", num1, num2);
                }
            }

            Console.ReadKey();
        }
    }
}