using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingClasses2_MIllerV2
{
    class Input
    {
        public static void SetInput()
        {
            Console.Write("Enter Number 1: ");
            DeclareVar.num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number 2: ");
            DeclareVar.num2 = Convert.ToInt32(Console.ReadLine());
        }
    }
}
