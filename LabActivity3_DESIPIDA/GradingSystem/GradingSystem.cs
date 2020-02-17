
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
            double grade;
            string grades;
            Console.Write("Enter your final grade\t: ");
            grades = Console.ReadLine();
            

            try
            {
                if (grades.Equals("INC") || grades.Equals("inc"))
                {
                    Console.WriteLine("Grade Equivalent\t: INC");
                    Console.WriteLine("Remarks\t\t\t:Incomplete");
                }

                else
                {
                    grade = Convert.ToDouble(grades);
                    //grade = Math.Ceiling(grade);
                    //grade =Math.Floor(grade);
                    grade = Math.Round(grade, MidpointRounding.AwayFromZero);

                    if ((grade <= 100.00) && (grade >= 98.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 1.25");
                        Console.WriteLine("Remarks\t\t\t: Excellent");
                    }
                    else if ((grade <= 97.00) && (grade >= 95.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 1.25");
                        Console.WriteLine("Remarks\t\t\t: Excellent");
                    }
                    else if ((grade <= 94.00) && (grade >= 92.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 1.50");
                        Console.WriteLine("Remarks\t\t\t: Very Good");
                    }
                    else if ((grade <= 91.00) && (grade >= 89.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 1.75");
                        Console.WriteLine("Remarks\t\t\t: Very Good");
                    }
                    else if ((grade <= 88.00) && (grade >= 86.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 2.00");
                        Console.WriteLine("Remarks\t\t\t: Good");
                    }
                    else if ((grade <= 85.00) && (grade >= 83.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 2.25");
                        Console.WriteLine("Remarks\t\t\t: Good");
                    }
                    else if ((grade <= 82.00) && (grade >= 80.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 2.50");
                        Console.WriteLine("Remarks\t\t\t: Fair");
                    }
                    else if ((grade <= 79.00) && (grade >= 77.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 2.75");
                        Console.WriteLine("Remarks\t\t\t: Passed");
                    }
                    else if ((grade <= 76.00) && (grade >= 75.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 3.00");
                        Console.WriteLine("Remarks\t\t\t: Passed");
                    }
                    else if ((grade <= 74.00) && (grade >= 72.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 4.00");
                        Console.WriteLine("Remarks\t\t\t: CONDITIONAL (MT only)");
                    }
                    else if ((grade <= 71.00) && (grade >= 60.00))
                    {
                        Console.WriteLine("Grade Equivalent\t: 5.00");
                        Console.WriteLine("Remarks\t\t\t: Failed");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();


        }
    }
}
