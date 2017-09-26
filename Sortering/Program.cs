using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortering
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };

            Array.Sort(hunde);

            foreach (Hund h in hunde)
            {
                Console.WriteLine(h.Navn);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }

        }
    }

    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(object obj)
        {
            Hund hund = obj as Hund;
            if (hund.Alder > this.Alder)
            {
                return 1;
            }
            if (hund.Alder < this.Alder)
            {
                return -1;
            }
            return 0;
        }
    }
}
