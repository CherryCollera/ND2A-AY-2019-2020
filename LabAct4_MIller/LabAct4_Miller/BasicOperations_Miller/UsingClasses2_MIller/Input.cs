
using UsingClasses2_MIller;

namespace UsingClasses2_MIller
{
    class Input 
    {
        public static int num1, num2;
        public int numb1()
        {
            System.Console.Write("Input Number 1: ");
            num1 = System.Convert.ToInt32(System.Console.ReadLine());
            return num1;
        }
        public int numb2()
        {
            System.Console.Write("Input Number 2: ");
            num2 = System.Convert.ToInt32(System.Console.ReadLine());
            return num2;
        }
    }
}
