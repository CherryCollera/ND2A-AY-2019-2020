using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    class While
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<10)
            {
                Console.Write("While statement ");
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
