using System;


namespace ComputeAverage
{
    class ComputeAverage
    {
        static void Main(string[] args)
        {
            int num1, num2,num3,num4,num5,ave,fave;
            Console.WriteLine("Enter 5 grade: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            num4 = Convert.ToInt32(Console.ReadLine());
            num5 = Convert.ToInt32(Console.ReadLine());
            ave = num1 + num2 + num3 + num4 + num5;
            fave = ave / 5;
            Console.Write("the average is = {0:0.000} ", fave);
            Console.ReadLine();
        }
    }
}
