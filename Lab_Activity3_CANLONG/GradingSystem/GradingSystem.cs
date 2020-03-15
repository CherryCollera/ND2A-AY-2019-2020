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
            string grade;
            double gs;

            Console.Write("Enter your Final Grade : ");
            grade = Console.ReadLine();



            try
            {
                if (grade.Equals("INC") || grade.Equals("inc"))
                {
                    Console.WriteLine("Grade Equivalent : INC\nRemarks: Incomplete");
                }



                else
                {
                    gs = Convert.ToDouble(grade);

                    if ((gs >= 97.5) && (gs <= 100.0))
                    {
                        Console.WriteLine("Grade Equivalent : 1.00\nRemarks: Excellent");
                    }
                    else if ((gs >= 94.5) && (gs <= 97.4))
                    {
                        Console.WriteLine("Grade Equivalent : 1.25\nRemarks: Excellent");
                    }
                    else if ((gs >= 91.5) && (gs <= 94.4))
                    {
                        Console.WriteLine("Grade Equivalent : 1.50\nRemarks: Very Good");
                    }
                    else if ((gs >= 88.5) && (gs <= 91.4))
                    {
                        Console.WriteLine("Grade Equivalent : 1.75\nRemarks: Very Good");
                    }
                    else if ((gs >= 85.5) && (gs <= 88.4))
                    {
                        Console.WriteLine("Grade Equivalent : 2.00\nRemarks: Good");
                    }
                    else if ((gs >= 82.5) && (gs <= 85.4))
                    {
                        Console.WriteLine("Grade Equivalent : 2.25\nRemarks: Good");
                    }
                    else if ((gs >= 79.5) && (gs <= 82.0))
                    {
                        Console.WriteLine("Grade Equivalent : 2.50\nRemarks: Fair");
                    }
                    else if ((gs >= 76.5) && (gs <= 79.4))
                    {
                        Console.WriteLine("Grade Equivalent : 2.75\nRemarks: Passed");
                    }
                    else if ((gs >= 74.5) && (gs <= 76.4))
                    {
                        Console.WriteLine("Grade Equivalent : 3.00\nRemarks: Passed");
                    }
                    else if ((gs >= 72.5) && (gs <= 74.4))
                    {
                        Console.WriteLine("Grade Equivalent : 4.00\nRemarks: Conditional");
                    }
                    else if ((gs >= 60.0) && (gs <= 72.4))
                    {
                        Console.WriteLine("Grade Equivalent : 5.00\nRemarks: Failed");
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
