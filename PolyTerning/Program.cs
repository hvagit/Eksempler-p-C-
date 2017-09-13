using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyTerning
{
    class Program
    {
        static void Main(string[] args)
        {
            LudoTerning l = new LudoTerning();
            l.Skriv();
            LudoTerning g = new LudoTerning(3);
            g.Skriv();
            LudoTerning s = new LudoTerning(5);
            s.Skriv();
            LudoTerning e = new LudoTerning(1);
            e.Skriv();

            Terning t = new Terning();
            t.Skriv();
            Terning t2 = new Terning(2);
            t2.Skriv();

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
            get
            {
                Console.WriteLine("Aflæser vaerdi " + this.vaerdi);
                return vaerdi;
            }
            set
            {
                if (value >= 1 && value <= 6)
                {
                    Console.WriteLine("Sætter vaerdi " + value);
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
            Console.WriteLine("Terningens værdi er [" + this.Vaerdi + "}");
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

        // new
        public new void Skriv()
        {
            string ud = "Terningens værdi er[";
            if (this.ErGlobus())
            {
                ud += "G";
            }
            else if (this.ErStjerne())
            {
                ud += "S";
            }
            else
                ud += this.Vaerdi;
            ud += "]";
            Console.WriteLine(ud);
        }
    }



}
