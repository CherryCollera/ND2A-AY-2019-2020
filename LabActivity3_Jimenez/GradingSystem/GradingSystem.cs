using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class GradingSystem
    {
        static void Main(string[] args)
        {
            string num1;
            double grade;

            Console.Write("Enter your final grade: ");
            num1 = Console.ReadLine();

            if (num1.Equals("INC") || num1.Equals("inc"))
            {
                Console.WriteLine("Grade Equivalent : INCOMPLETE");
                Console.WriteLine("Remarks\t\t : INCOMPLETE");
            }
            
   
            else
            {
                grade = Convert.ToDouble(num1);
                if ((grade >= 98) && (grade <= 100))
                {
                    Console.WriteLine("Grade Equivalent : 1.0");
                    Console.WriteLine("Remarks\t\t : Excellent");
                }
                else
                {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 95) && (grade <= 98))
                    {
                        Console.WriteLine("Grade Equivalent : 1.25");
                        Console.WriteLine("Remarks\t\t : Very Good");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 92) && (grade <= 95))
                    {
                        Console.WriteLine("Grade Equivalent : 1.50");
                        Console.WriteLine("Remarks\t\t : Very Good");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 89) && (grade <= 92))
                    {
                         Console.WriteLine("Grade Equivalent : 1.75");
                         Console.WriteLine("Remarks\t\t : Very Good");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 86) && (grade <= 89))
                    {
                          Console.WriteLine("Grade Equivalent : 2.0");
                          Console.WriteLine("Remarks\t\t : Good");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 83) && (grade <= 86))
                    {
                          Console.WriteLine("Grade Equivalent : 2.25");
                          Console.WriteLine("Remarks\t\t : Good");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 80) && (grade <= 83))
                    {
                          Console.WriteLine("Grade Equivalent : 2.50");
                          Console.WriteLine("Remarks\t\t : Fair");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 77) && (grade <= 80))
                    {
                          Console.WriteLine("Grade Equivalent : 2.75");
                          Console.WriteLine("Remarks\t\t : Passed");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 75) && (grade <= 77))
                    {
                          Console.WriteLine("Grade Equivalent : 3.0");
                          Console.WriteLine("Remarks\t\t : Passed");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 72) && (grade <= 75))
                    {
                          Console.WriteLine("Grade Equivalent : 4.0");
                          Console.WriteLine("Remarks\t\t : Condionational (MT Only");
                    }
                    else
                    {
                    grade = Convert.ToDouble(num1);
                    if ((grade >= 60) && (grade <= 72))
                    {
                          Console.WriteLine("Grade Equivalent : 5.0");
                          Console.WriteLine("Remarks\t\t : Failed");
                    }

                        }
                    }

                }   

                     Console.ReadKey();







        }
    }
}
