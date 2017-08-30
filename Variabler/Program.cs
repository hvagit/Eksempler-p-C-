using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            Console.WriteLine("Skulle give 11: "+heltal);

            heltal--;
            Console.WriteLine("Skulle give 10: " + heltal);

            heltal += 20;
            Console.WriteLine("Skulle give 30: " + heltal);

            double kommatal = 12.5;
            kommatal++;
            Console.WriteLine("Skulle give 13.5: " + kommatal);

            kommatal--;
            Console.WriteLine("Skulle give 12.5: " + kommatal);

            kommatal *= 2;
            Console.WriteLine("Skulle give 25: " + kommatal);

            FilType pdf = FilType.Pdf;
            Console.WriteLine("Skulle give Pdf: "+pdf);
            Console.WriteLine("Skulle give 7: " + Convert.ToInt32(pdf));
            Console.WriteLine("Skulle også give 7: " + (int) pdf);

            DateTime dato = DateTime.Now;
            Console.WriteLine("Skulle give 300817: "+dato.ToString("ddMMyy"));
            Console.WriteLine("Skulle give 30. august 2017: " + dato.ToLongDateString());
            Console.WriteLine("Skulle give 30-8-17: " + dato.ToString("d-M-y"));

            // Bruger ikke new til init.
            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";

            Console.WriteLine("Skulle give Mikkel: "+p.Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    enum FilType : byte
    {
        Csv = 8,
        Pdf = 7,
        Txt = 9
    }

    struct Person
    {
        public int Id;
        public string Navn;
    }
}
