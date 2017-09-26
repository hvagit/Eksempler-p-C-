using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KortEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Vaerdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Vaerdi = 7 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Vaerdi = 3 });
            b.VisKort();

            Kort k = b.FjernKort();
            Console.WriteLine();
            Console.WriteLine(k.ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Kort
    {
        public string Kulør { get; set; }
        public int Vaerdi { get; set; }

        public override string ToString()
        {
            return this.Kulør + " " + this.Vaerdi;
        }
    }

    class Bunke
    {
        private Stack<Kort> kortBunke = new Stack<Kort>();

        public void TilføjKort(Kort kort)
        {
            kortBunke.Push(kort);
        }

        public Kort FjernKort()
        {
            // Faktisk bør vi sikre os, at der er mindst et element i bunken...
            if(kortBunke.Count > 0)
            return kortBunke.Pop();

            return null;
        }

        public void VisKort()
        {
            foreach (var item in kortBunke)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
