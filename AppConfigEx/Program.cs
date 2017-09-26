using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace AppConfigEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GepAppSetting("ip", "127.0.0.1"));
            Console.WriteLine(GepAppSetting("maxrecords", "200"));

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }

/*        static string GepAppSetting(string key, string defaultValue)
        {
            string s = ConfigurationManager.AppSettings[key];
            if (s != null)
            {
                return s;
            }
            return defaultValue;
        }*/

        static T GepAppSetting<T>(string key, T defaultValue)
        {
            string s = ConfigurationManager.AppSettings[key];
            if (s != null)
            {
                return (T)Convert.ChangeType(s, typeof(T));
            }
            return defaultValue;
        }

    }
}
