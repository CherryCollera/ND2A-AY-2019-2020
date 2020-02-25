using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2_Paulo
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
