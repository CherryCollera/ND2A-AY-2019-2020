using System;


namespace ComputeAverage
{
    class ComputeAverage
    {
        static void Main(string [] args)
        {
            double num1, num2, num3, num4, num5;
            Console.WriteLine("Enter 5 grades: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());
            num3 = Convert.ToDouble(Console.ReadLine());
            num4 = Convert.ToDouble(Console.ReadLine());
            num5 = Convert.ToDouble(Console.ReadLine());
            Console.ReadKey();

            Console.Write("The average is {0:0.0} ", (num1 + num2 + num3 + num4 + num5)/5);
            Console.ReadKey();
        }
    }
}
