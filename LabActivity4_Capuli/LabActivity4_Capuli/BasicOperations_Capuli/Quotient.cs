using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Capuli
{
    class Quotient
    {
        public void getQuotient()
        {
            DeclareVar.quotient = DeclareVar.num1 / DeclareVar.num2;
            Console.WriteLine("Quotient : " + DeclareVar.quotient);
        }
    }
}
