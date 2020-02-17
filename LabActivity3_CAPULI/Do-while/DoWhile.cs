using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_while
{
    class DoWhile
    {
        static void Main(string[] args)
        {
            int[] GEF06_nms = new int[] { 6, 7, 8, 10 };
            int GEF06_sum = 0;
            int i = 0;
            do
            {
                GEF06_sum += GEF06_nms[i];
                i++;
            } while (i < 4);

            Console.WriteLine(GEF06_sum);
            Console.ReadKey();
        }
    }
}
