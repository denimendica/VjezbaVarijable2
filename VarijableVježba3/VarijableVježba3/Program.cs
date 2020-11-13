using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarijableVježba3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=2;
            double b=5;
            double c=7;
            double d=4;

            double x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) / (Math.Pow(a+b, 2) + Math.Pow(c+d, 2) );

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
