using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund h1 = new Hund() { Navn = "Bjørn", LydNiveau = 2 };
            Hund h2 = new Hund() { Navn = "Molly", LydNiveau = 7 };
            Console.WriteLine(h1>h2);
        }
    }

    class Hund
    {
        public string Navn { get; set; }
        public int LydNiveau { get; set; }

        public static bool operator > (Hund a, Hund b)
        {
            return a.LydNiveau > b.LydNiveau;
        }

        public static bool operator <(Hund a, Hund b)
        {
            return a.LydNiveau < b.LydNiveau;
        }
    }
}
