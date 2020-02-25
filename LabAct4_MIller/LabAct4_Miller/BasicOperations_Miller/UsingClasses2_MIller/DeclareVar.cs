
using UsingClasses2_MIller;

namespace UsingClasses2_MIller
{
    
    class DeclareVar
    {
        public void declareVar()
        {
            int a, b;
            Sum s = new Sum();
            Difference dif = new Difference();
            Product pr = new Product();
            Quotient qu = new Quotient();
            Remainder re = new Remainder();            
            Input inp = new Input();
            a = inp.numb1();
            b = inp.numb2();
            System.Console.WriteLine("\nSum:\t\t" + s.getSum(a, b));
            System.Console.WriteLine("Difference:\t" + dif.getDifference(a, b));
            System.Console.WriteLine("Product:\t" + pr.getProduct(a, b));
            System.Console.WriteLine("Quotient:\t" + qu.getQuotient(a, b));
            System.Console.WriteLine("Remainder:\t" + re.getRemainder(a, b));


        }
    }
}
