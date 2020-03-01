using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2_example_Caguimbal
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
