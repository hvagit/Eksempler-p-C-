using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArealBeregninger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cirkel "+ArealBeregninerC.BeregnArealCirkel(0.5));
            Console.WriteLine("Firkant "+ArealBeregninerC.BeregnArealFirkant(5, 7));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    static class ArealBeregninerC
    {
        public static double BeregnArealFirkant(double b, double h)
        {
            return b*h;
        }
        public static double BeregnArealCirkel(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
    }
}
