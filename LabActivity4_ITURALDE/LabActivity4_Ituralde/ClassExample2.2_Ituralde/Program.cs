using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample2._2_Ituralde
{
    class Program
    {
        static void Main(string[] args)
        {
            Accept a = new Accept();
            a.AcceptDetails();
            Console.ReadLine();

            Car AcceptDetails;
            AcceptDetails = new Car(a.col1, a.col2);
            Console.WriteLine(AcceptDetails.Describe());


            AcceptDetails = new Car(a.col1, a.col2);
            Console.WriteLine(AcceptDetails.Describe2());

            Console.ReadKey();
        }
    }
}
