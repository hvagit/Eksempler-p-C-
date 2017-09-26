using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] arr = new IDbFunktioner[2];
            arr[0] = new Hund();
            arr[1] = new Ubåd();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Gem();
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }

        }
    }

    class Hund : IDbFunktioner
    {
        public string Navn { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer hund");
        }
    }

    class Ubåd : IDbFunktioner
    {
        public int Nummer { get; set; }
        public double Turbine { get; set; }

        public void Gem()
        {
            Console.WriteLine("Gemmer ubåd");
        }
    }

    interface IDbFunktioner
    {
        void Gem();
    }

}
