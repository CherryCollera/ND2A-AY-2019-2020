using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample2_Canlong
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car;
            car = new Car( " Red");
            Console.WriteLine(car.Describe());
            car = new Car(" Green");
            Console.WriteLine(car.Describe());
            Console.ReadLine();
        }
    }
}
