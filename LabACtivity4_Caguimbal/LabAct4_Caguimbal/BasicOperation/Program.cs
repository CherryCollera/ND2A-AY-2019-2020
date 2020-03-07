using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            // public void declareVar()
            {
                int a, b;
                Sum s = new Sum();
                Difference d = new Difference();
                Product p = new Product();
                Quotient q = new Quotient();
                Remainder r = new Remainder();
                Input i = new Input();
                a = i.number1();
                b = i.number2();
                Console.WriteLine("\nSum:\t\t\t" + s.getSum(a, b));
                Console.WriteLine("\nDifference:\t\t" + d.getDifference(a, b));
                Console.WriteLine("\nProduct:\t\t" + p.getProduct(a, b));
                Console.WriteLine("\nQuotient:\t\t" + q.getQuotient(a, b));
                Console.WriteLine("\nRemainder:\t\t" + r.getRemainder(a, b));

                Console.ReadLine();
            }
        }
    }
}
