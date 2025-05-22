using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kordamine
{
    class Startclass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast!");
            Console.WriteLine("Sisesta oma eesnimi: ");
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            

            Console.Write("\n\nSisesta esimene arv: ");
            int arv1 = int.Parse(Console.ReadLine());

            Console.Write("Sisesta esimene arv: ");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            Console.ReadLine();
        }
    }
}
