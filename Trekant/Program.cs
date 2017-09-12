using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(7, 4);
            Console.WriteLine(t.Areal);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Trekant
    {
        public int Grundlinje { get; private set; }
        public int Højde { get; private set; }
        public Trekant(int h, int g)
        {
            Grundlinje = g;
            Højde = h;
        }

        // Denne form vælges, da der skal gøres noget i getter-metoden for denne egenskab.
        public double Areal {
            get
            {
                    return 0.5 * this.Grundlinje * this.Højde;
            }
        }
    }
}
