using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldEx
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            IEnumerable<int> a = GetColl(2);
            Console.WriteLine("Hej "+a);
            Console.WriteLine("Slut");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }

        public static IEnumerable<int> GetColl(int c)
        {
            Console.WriteLine("Hallo");
            for (int i = 0; i < c; i++)
            {
                // Todo: mangler liste for at være interessant

                //int t = rnd.Next(0, 100);
                //Console.WriteLine("index "+i);
                yield return i+14;
            }


        }
    }
}
