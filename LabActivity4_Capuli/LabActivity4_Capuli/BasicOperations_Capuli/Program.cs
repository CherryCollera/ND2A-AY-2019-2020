using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperations_Capuli
{
    class Program
    {
        public static void Main(string [] args)
        {

            Input inp = new Input();
            inp.numb1();
            Sum s = new Sum();
            s.getSum();
            Difference d = new Difference();
            d.getDifference();
            Product p = new Product();
            p.getProduct();
            Quotient q = new Quotient();
            q.getQuotient();
            Remainder r =new  Remainder();
            r.getRemainder();
            Console.ReadKey();
        }
    }
}
