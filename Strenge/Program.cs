using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn = "Mikkel";
            string efternavn = "Cronberg";

            // Kunne lave en udgave med stringbuilder
            string samletnavn = fornavn + " " + efternavn;
            Console.WriteLine(samletnavn);
            Console.WriteLine(samletnavn.Length);
            Console.WriteLine(samletnavn.Substring(7));
            Console.WriteLine(samletnavn.Substring(7, 4));

            StringBuilder sb = new StringBuilder();
            sb.Append(fornavn);
            sb.Append(" ");
            sb.Append(efternavn);

            string navnstort = samletnavn.ToUpper();
            Console.WriteLine(navnstort);
            string navnlille = samletnavn.ToLower();
            Console.WriteLine(navnlille);

            string [] arr = samletnavn.Split(' ');
            Console.WriteLine(arr.Length);

            Console.WriteLine(string.Join("", arr));

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            string s = "abc\tdef";
            Console.WriteLine("Escape t "+s);

            string t = "abc\ndef";
            Console.WriteLine("Escape n " + t);

            string u = "abc\rdef";
            Console.WriteLine("Escape r " + u);

            string dataTilFil = "Tekst i fil";
            System.IO.File.WriteAllText(@"X:\nyFil.txt", dataTilFil);


            char pad = ' ';
            string linie = "";
            for (int i = 0; i < 10; i++)
            {
                linie = "";
                for (int j = 0; j < 10; j++)
                {
                    int tal = (i + 1) * (j + 1);
                    string number = tal + "";
                    if (tal == 90)
                    {
                        number = number.PadRight(3, pad);
                    }
                    else
                    {
                        number = number.PadLeft(2, pad);
                        number = number.PadRight(4, pad);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    if (tal > 50)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }

                    linie += number;

                    Console.Write(number);
                }
                Console.WriteLine();
                // Console.WriteLine(linie);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }

        }
    }
}
