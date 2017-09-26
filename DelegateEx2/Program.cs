using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEx2
{
    class Program
    {
        public delegate void Log(string text);

                static void AppendLog(string txt)
                {
                    System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
                }

        static void Main(string[] args)
        {
            Maskine m = new Maskine();
            m.LogFunktion = Console.WriteLine;// ingen parrenteser...kun funktionsnavn
            //m.LogFunktion += AppendLog;// ingen parrenteser...kun funktionsnavn
            m.LogFunktion += txt => System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
            m.Start();
            m.Stop();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    // Til forskel fra Action skal denne defineres udenfor klassen...
    //public delegate void Log(string txt);

    class Maskine
    {
        // NB: Bemærk: getter/setter
        public Action<string> LogFunktion { get; set; }

        // Egenskab af typen Log...egenskabens navn er LogFunction.
        //public Log LogFunktion { get; set; }

        public void Start()
        {
            LogFunktion(DateTime.Now.ToLongTimeString() +"Start");
        }

        public void Stop()
        {
            LogFunktion(DateTime.Now.ToLongTimeString() + "Start");
        }
    }
}
