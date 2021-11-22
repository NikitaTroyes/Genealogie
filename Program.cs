using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogie
{
    class Program
    {
        static void Main(string[] args)
        {

            Person personA = new Member("Léon", "Blum", 1872, 1950, "oncle");
            Person personB = new Member("Jules", "Ferry", 1832, 1896, "cousin" );
            Person personC = new Member("Marie", "Curie", 1868, 1934, "tante");

            Genitor newFamily = new Genitor("Simone", "Veil", 1927);
            newFamily.Add(personA);
            newFamily.Add(personB);
            newFamily.Add(personC);

            Console.WriteLine(newFamily.GetData());
            Console.ReadLine(); 
        }
    }
}
