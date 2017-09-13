using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlHaandtering
{
    class Program
    {
        // Logningen lægges relativt ift. dette projekt...i bin/Debug/logs
        private static Logger logger = LogManager.GetCurrentClassLogger();
            
        static void Main(string[] args)
        {
            try
            {
                logger.Debug("Hip Hip");
                Run();
                logger.Debug("Hurra");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl"+ex.Message);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indtast 2. tal");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("Resultatet er: "+res);
        }
    }
}
