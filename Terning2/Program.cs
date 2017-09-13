using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Terning t1 = new Terning();
            t1.Skriv();
            Terning t2 = new Terning(4);
            t2.Skriv();*/

            LudoTerning globus = new LudoTerning(3);
            Console.WriteLine("Er globus: "+globus.ErGlobus());
            Console.WriteLine("Er stjerne: " + globus.ErStjerne());

            LudoTerning stjerne = new LudoTerning(5);
            Console.WriteLine("Er stjerne: " + stjerne.ErStjerne());
            Console.WriteLine("Er globus: " + stjerne.ErGlobus());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Terning
    {
        private static Random rnd;

        static Terning()
        {
            rnd = new Random();
        }

        private int vaerdi;

        public int Vaerdi
        {
            get {
                Console.WriteLine("Aflæser vaerdi " + this.vaerdi);
                return vaerdi;
            }
            set {if (value >= 1 && value <= 6)
                {
                    Console.WriteLine("Sætter vaerdi "+value);
                    vaerdi = value;
                }
                else
                {
                    Console.WriteLine("Sætter vaerdi " + 1);
                    vaerdi = 1;
                }
            }
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int vaerdi)
        {
            this.Vaerdi = vaerdi;
        }

        public int Ryst()
        {
            this.Vaerdi = rnd.Next(1, 7);
            return this.Vaerdi;
        }

        public void Skriv()
        {
            Console.WriteLine("Terningens værdi er ["+this.Vaerdi+"}");
        }
    }

    class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            if (Vaerdi == 3)
            {
                return true;
            }
            return false;
        }
        public bool ErStjerne()
        {
            if (Vaerdi == 5)
            {
                return true;
            }
            return false;
        }

        public LudoTerning() : base()
        {
        }

        public LudoTerning(int t) : base(t)
        {
        }

    }

}
