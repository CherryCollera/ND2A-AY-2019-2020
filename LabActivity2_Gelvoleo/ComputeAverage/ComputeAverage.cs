using System;

namespace ComputeAverage
{
    class ComputeAverage
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4, num5, num6;
            Console.WriteLine("Enter 5 grades: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            num4 = Convert.ToDouble(Console.ReadLine());
            num5 = Convert.ToDouble(Console.ReadLine());
            num6 = (num1 + num2 + num3 + num4 + num5) / 5;
            Console.WriteLine("The Average is {0:0.000}. ",num6);
            Console.ReadKey();
        }
    }
}