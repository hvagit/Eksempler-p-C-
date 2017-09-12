using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Henrik", "Andreassen", 1969);
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(p.Alder());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }

        }
    }

    class Person
    {
        public string forNavn;
        public string efterNavn;
        public int fødselsår;

        public Person()
        {
            this.forNavn = "";
            this.efterNavn = "";
            this.fødselsår = 0;
        }

        public Person(string fornavn, string efternavn, int fAar)
        {
            if (fornavn == null)
            {
                this.forNavn = "";
            }
            else
            {
                this.forNavn = fornavn.ToUpper();
            }

            if (efternavn == null)
            {
                this.efterNavn = "";
            }
            else
            {
                this.efterNavn = efternavn.ToUpper();
            }
            this.fødselsår = fAar;
        }

        public string FuldtNavn()
        {
            return forNavn + " " + efterNavn;
        }

        public int Alder()
        {
            DateTime nu = DateTime.Now;
            int aar = nu.Year;
            return fødselsår - aar;
        }
    }
}
