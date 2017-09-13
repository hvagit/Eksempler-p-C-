using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Efternavn = "Ib";
            Console.WriteLine("Efternavn: "+p.Efternavn);
            p.Efternavn = "Dali";
            Console.WriteLine("Efternavn: " + p.Efternavn);
            p.Fornavn = "Salvador";
            Console.WriteLine("Fuldt navn: " + p.FuldtNavn());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public Person()
        {
        }

        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set {if (value != null && value.Length > 3)
                {
                    efternavn = value;
                }
                else {
                    efternavn = "";
                }
                }
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }

    }
}
