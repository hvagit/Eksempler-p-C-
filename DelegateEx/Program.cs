using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx
{


    class Program
    {
        // NB: delegate defineres i klassen
        public delegate int Beregn(int a, int b);
        
        static void Main(string[] args)
        {
            Beregn beregner = new Beregn(Plus);
            Console.WriteLine(beregner(2,3));

            Console.WriteLine(Beregner(1, 1, Plus));
            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }

        // Delegate-param kan erstattes med funktionerne Plus, Minus mv.
        public static int Beregner(int a, int b, Beregn p)
        {
            // Ikke noget med switch...delegate kan se, hvilken funktion der peges på...gennem p-parameteren.
            Beregn d = new Beregn(p);
            return d(a, b);
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Divider(int a, int b)
        {
            return a/b;
        }
        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }


}
