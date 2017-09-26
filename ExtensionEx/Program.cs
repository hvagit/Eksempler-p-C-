using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdefg";
            Console.WriteLine(s.FormatName());

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }

    static class Udvidelse
    {
        // public, static...i static class
        public static string FormatName(this string name)
        {
            if (name == null)
            {
                return null;
            }
            if (name.Length == 1)
            {
                return name.ToUpper();
            }
            return name.Substring(0, 1).ToUpper() + name.Substring(1);
        }
    }
}
