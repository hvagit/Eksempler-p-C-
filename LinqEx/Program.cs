using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var personer = new PersonNuGetPackage.PersonRepositoryRandom();

            var people = personer.GetPeople(10);
            foreach (var item in people)
            {
                //Console.WriteLine(item.Name);
            }

            var sorteret = people.OrderBy(p => p.Name);
            foreach (var item in sorteret)
            {
                Console.WriteLine(item.Name);
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.WriteLine("PRESS ANY KEY TO CONTINUE");
                Console.ReadKey();
            }
        }
    }
}
