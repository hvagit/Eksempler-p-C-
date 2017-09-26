using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DisposeEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            string path = @"x:\dyrenavne.txt";
            using (StreamReader stream = System.IO.File.OpenText(path))
            {
                while (stream.Peek() != -1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn);
                }
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }
}
