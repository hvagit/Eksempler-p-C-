using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Fornavn = "Ib";
            p.Efternavn = "Rene";
            Console.WriteLine(p.FuldtNavn());
            Elev e = new Elev();
            e.Efternavn = "Jones";
            e.Fornavn = "Indiana";
            Console.WriteLine(e.FuldtNavn());
            Instruktør i = new Instruktør();
            i.Efternavn = "Jensen";
            i.Fornavn = "Jens";
            Console.WriteLine(i.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
    }

    class Elev : Person
    {
        public string KlasseLokale { get; set; }
    }

    class Instruktør : Person
    {
        public int NoegleId { get; set; }
    }
}
