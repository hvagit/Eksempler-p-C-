﻿using System;
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

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }

        }
    }
}
