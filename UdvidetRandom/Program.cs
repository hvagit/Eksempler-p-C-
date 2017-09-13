using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdvidetRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    class UdvidetRandom : System.Random
    {
        public bool NextBool()
        {
            if (base.Next(1, 1002) < 500)
            {
                Console.WriteLine("Under -> True");
                return true;
            }
            Console.WriteLine("Over -> False");
            return false;
        }
    }
}
