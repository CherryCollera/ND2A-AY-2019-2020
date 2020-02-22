

using BasicOperations_Agomaa;

class Declarevar
{
    public void Declaringvar()
    {
        double a, b;
        Sum s = new Sum();
        Difference d = new Difference();
        Product p = new Product();
        Quotient t = new Quotient();
        Remainder r = new Remainder();
        Input ip = new Input();
        a = ip.number1();
        b = ip.number2();


        System.Console.WriteLine("Sum\t\t:\t\t " + s.AcceptSum(a, b));
        System.Console.WriteLine("Difference\t:\t\t " + d.getDifference(a, b));
        System.Console.WriteLine("Product\t\t:\t\t " + p.getProduct(a, b));
        System.Console.WriteLine("Quotient\t:\t\t " + t.getQuotient(a, b));
        System.Console.WriteLine("Remainder\t:\t\t " + r.getRemainder(a, b));

    }

}

