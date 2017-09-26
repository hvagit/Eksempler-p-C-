using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventEx
{
    class Program
    {
        static void Main(string[] args)
        {

            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            // Logger når filen bliver ændret
            w.Changed += W_Changed;
            do
            {

            } while (true);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine(e.FullPath);
            Console.WriteLine(e.ChangeType);
            Console.WriteLine(e.Name);
            Console.WriteLine("-----------------");
        }
    }
}
