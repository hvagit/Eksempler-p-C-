using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reku
{
    class Program
    {
        static void Main(string[] args)
        {
            reku(10);
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }

        }

        static void reku(int number)
        {
            if (number - 1 > 0)
            {
                reku(number - 1);
            }
            // Udskriver første gang, når vi er i bunden af alle kaldene
            Console.WriteLine(number);
        }
    }
}

