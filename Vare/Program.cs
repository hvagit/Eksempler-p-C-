using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare(12.50, "Corn Flakes");
            Console.WriteLine(v.PrisMedMoms());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Vare
    {
        private string navn;

        public string Navn
        {
            get
            {
                Console.WriteLine("Getter navn");
                return navn;
            }
            set
            {
                Console.WriteLine("Setter navn");
                navn = value;
            }
        }

        private double pris;

        public double Pris
        {
            get
            {
                Console.WriteLine("Getter pris");
                return pris;
            }
            set
            {
                Console.WriteLine("Setter pris");
                pris = value;
            }
        }

        public Vare()
        {
            this.Pris = 0.0;
            this.Navn = "";
        }

        public Vare(double pris, string navn)
        {
            this.Pris = pris;
            this.Navn = navn;
        }

        public double PrisMedMoms()
        {
            return this.Pris * 1.25;
        }


    }

}
