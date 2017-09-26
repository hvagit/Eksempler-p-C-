using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEx1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> personListe = new List<Person>();
            personListe.Add(new Person(48, "Henrik"));
            personListe.Add(new Person(44, "Peter"));
            personListe.Add(new Person(43, "Hanne"));

            foreach (Person p in personListe)
            {
                //Console.WriteLine(p.Navn);
            }

            Dictionary<int, Person> dict = new Dictionary<int, Person>();
            dict.Add(1969, new Person(48, "Henrik"));
            dict.Add(1973, new Person(44, "Peter"));
            dict.Add(1974, new Person(43, "Hanne"));

            Console.WriteLine(dict[1969].Navn);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public int Alder { get; set; }
        public string Navn { get; set; }

        public Person(int age, string navnet)
        {
            this.Alder = age;
            this.Navn = navnet;
        }
    }
}
