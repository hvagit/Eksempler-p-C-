using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kunde k = new Kunde { Navn="Henrik", KreditMax = -500 };// Det tal vi må skylde væk er negativt.
            // Det skal defineres heropppe, hvad der skal ske, når event fyres
            k.KreditOverskredet += (s, e) =>
            {
                Console.WriteLine("Kredit overskredet");
            };
            k.Køb(100);
            k.Køb(400);
            k.Køb(1);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Kunde
    {
        // Knytter eventHandler til eventen KreditOverskredet
        public event EventHandler KreditOverskredet;
        public string Navn { get; set; }
        public int Saldo { get; set; }
        public int KreditMax { get; set; }

        public void Køb(int vaerdi)
        {
            this.Saldo -= vaerdi;
            Console.WriteLine("Kunde {0} køber for {1}...Ny saldo {2}", Navn, vaerdi, Saldo);
            if (Saldo < KreditMax)
            {
                // Fyr event
                if (KreditOverskredet != null)
                {
                    KreditOverskredet(this, new EventArgs());
                }
            }
        }

    }
}
