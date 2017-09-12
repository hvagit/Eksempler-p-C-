using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = null;
            p1 = new Person();
            Console.WriteLine(p1.ToString());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    public class Person
    {
        private int alder;// default: private
        private string navn;

        public void Udskriv()
        {
            Console.WriteLine(navn+" er "+alder);
        }
    }
}
