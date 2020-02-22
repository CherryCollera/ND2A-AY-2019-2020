using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Capuli
{
    class Product
    {
        public void getProduct()
        {
            DeclareVar.product = DeclareVar.num1 * DeclareVar.num2;
            Console.WriteLine("Product : " + DeclareVar.product);

        }
        
    }   
    
}
