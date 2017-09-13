using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dyr
{
    class Program
    {
        static void Main(string[] args)
        {
/*            Dyr d = new Dyr();
            d.Navn = "Anders";
            d.SigNoget();
            Hund h = new Hund();
            h.Navn = "Bjørn";
            h.SigNoget();
            Kat k = new Kat();
            k.Navn = "Tarzan";
            k.SigNoget();*/

            Dyr[] dyrArr = new Dyr[20];
            for (int i = 0; i < dyrArr.Length; i++)
            {
                dyrArr[i] = Dyr.TilfældigtDyr();
            }

            for (int i = 0; i < dyrArr.Length; i++)
            {
                dyrArr[i].SigNoget();
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Dyr
    {
        static Random rnd;

        static Dyr()
        {
            rnd = new Random();
        }

        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine("Jeg er et dyr og hedder "+this.Navn);
        }

        public static Dyr TilfældigtDyr()
        {
            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int nr = rnd.Next(1, 21);
            //Console.WriteLine(nr);
            int type = new Random().Next(1, 21);
            if (type == 1)
            {
                Kat k = new Kat();
                k.Navn = navne[nr];
                return k;
            }
            else
            {
                Hund h = new Hund();
                h.Navn = navne[nr];
                return h;
            }

        }
    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en hund og hedder " + this.Navn);
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine("Jeg er en kat og hedder " + this.Navn);
        }
    }
}
