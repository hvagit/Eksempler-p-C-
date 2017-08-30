using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal[] lønninger = { 28000, 45000, 62000, 76000, 19000, 32000 };
            for (int i = 0; i < lønninger.Length; i++)
            {
                Console.WriteLine(lønninger[i]);
            }

            Console.WriteLine("Gennemsnit: " + lønninger.Average());
            // Formatering
            Console.WriteLine(lønninger.Average().ToString("N2"));

            decimal alleLønninger = 0;
            for (int i = 0; i < lønninger.Length; i++)
            {
                alleLønninger += lønninger[i];
            }
            Console.WriteLine("Beregnet gnsn: " + alleLønninger/lønninger.Length);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }
}
