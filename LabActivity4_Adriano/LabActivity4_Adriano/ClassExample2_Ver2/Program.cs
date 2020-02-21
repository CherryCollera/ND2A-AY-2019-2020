using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassExample2_Ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            thecolor a = new thecolor();
            a.AcceptColor();

            Car AcceptColor;
            AcceptColor = new Car(a.color1, a.color2);
            Console.WriteLine(AcceptColor.Describe());

            AcceptColor = new Car(a.color1, a.color2);
            Console.WriteLine(AcceptColor.Describes());

            Console.ReadLine();
        }
    }
}
