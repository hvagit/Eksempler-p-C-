using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }

        }
        public static void Swap<T>(ref T a, ref T b)
        {
            T tmp = a;
            a = b;
            b = tmp;
        }

    }

}
