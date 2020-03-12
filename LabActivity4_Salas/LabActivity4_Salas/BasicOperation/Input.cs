using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BasicOperation
{
    class Input
    {
        public static int num1, num2;
        public void number()
        {

            Console.WriteLine("ENTER NUMBER 1:");
            DeclareVar.num1 = Convert.ToInt32(Console.ReadLine());
            //return num1;


            Console.WriteLine("ENTER NUMBER 2:");
            DeclareVar.num2 = Convert.ToInt32(Console.ReadLine());
            //return num2;

        }
    }
}
