using System;


namespace Classexample2_Delarosa
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;

            car = new Car("Red");
            Console.WriteLine(car.Describe());
            car = new Car("Green");
            Console.WriteLine(car.Describe());
            Console.ReadLine();
        }
    }
}
