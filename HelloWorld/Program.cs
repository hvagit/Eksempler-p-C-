using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast dit navn og afslut med enter:");
            string indtastetNavn = Console.ReadLine();
            Console.WriteLine("Dit navn med store bogstaver: "+indtastetNavn.ToUpper());
            Console.WriteLine("Tryk på en vilkårlig key for at slutte");
            ConsoleKeyInfo c = Console.ReadKey();
            Console.WriteLine(c.Key);
            Console.ReadKey();  
        }
    }
}
