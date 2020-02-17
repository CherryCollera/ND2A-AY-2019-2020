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
            string incomplete;

            Console.Write("Enter your final grade : ");
            incomplete = Console.ReadLine();
            try {
                if (incomplete.Equals("INC") || incomplete.Equals("inc"))
                {
                    Console.WriteLine("Grade Equivalent\t: INC");
                    Console.Write("\nRemarks\t\t: Incomplete");
                }

                else
                {
                    grade = Convert.ToDouble(incomplete);
                    if (grade >= 97.60 && grade <= 100.0)
                    {

                        Console.Write("Grade Equivalent\t: 1.00");
                        Console.Write("\nRemarks\t\t: Excellent");
                    }
                    else if (grade >= 94.60 && grade <= 97.59)
                    {
                        Console.Write("Grade Equivalent\t: 1.25");
                        Console.Write("\nRemarks\t\t: Excellent");
                    }
                    else if (grade >= 91.60 && grade <= 94.59)
                    {
                        Console.Write("Grade Equivalent\t: 1.50");
                        Console.Write("\nRemarks\t\t: Very Good");
                    }
                    else if (grade >= 88.60 && grade <= 91.59)
                    {
                        Console.Write("Grade Equivalent\t: 1.75");
                        Console.Write("\nRemarks\t\t: Very Good");
                    }
                    else if (grade >= 85.60 && grade <= 88.59)
                    {
                        Console.Write("Grade Equivalent\t : 2.00");
                        Console.Write("\nRemarks\t\t: Good");
                    }
                    else if (grade >= 82.60 && grade <= 85.59)
                    {
                        Console.Write("Grade Equivalent\t: 2.25");
                        Console.Write("\nRemarks\t\t: Good");
                    }
                    else if (grade >= 79.60 && grade <= 82.59)
                    {
                        Console.Write("Grade Equivalent\t: 2.50");
                        Console.Write("\nRemarks\t\t: Fair");
                    }
                    else if (grade >= 76.60 && grade <= 79.59)
                    {
                        Console.Write("Grade Equivalent\t : 2.75");
                        Console.Write("\nRemarks\t\t: Passed");
                    }
                    else if (grade >= 74.60 && grade <= 76.59)
                    {
                        Console.Write("Grade Equivalent\t : 3.00");
                        Console.Write("\nRemarks\t\t: Passed");
                    }
                    else if (grade >= 71.60 && grade <= 74.59)
                    {
                        Console.Write("Grade Equivalent\t: 4.00");
                        Console.Write("\nRemarks\t\t: Conditional(MT only)");
                    }
                    else if ((grade >= 59.60) && (grade <= 71.59))
                    {
                        Console.Write("Grade Equivalent\t: 5.00");
                        Console.Write("\nRemarks\t\t: Failed");
                    }
                    else //For input of grades less than 60.
                    {
                        Console.Write("Grade Equivalent\t: 5.00");
                        Console.Write("\nRemarks\t\t: Failed");
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

            }

    }
}
