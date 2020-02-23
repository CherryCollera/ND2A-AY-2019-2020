using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Capuli
{
    class Sum
    {
        public void getSum()
        {
            DeclareVar.sum = DeclareVar.num1 + DeclareVar.num2;
            Console.WriteLine("\nSum : " + DeclareVar.sum);
        }
    }
}
