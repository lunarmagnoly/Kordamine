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
            //1.osa kysime eesnimi
            Console.WriteLine("Tere tulemast!");
            Console.WriteLine("Sisesta oma eesnimi: ");//lisasin, et oleks arusaadav, mis on vaja sisestada
            string eesnimi = Console.ReadLine();
            Console.WriteLine("Tere, " + eesnimi);
            //2. osas lisame if 
            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule lähme kinno!");
                Console.WriteLine("Kui vana sa oled?");
                int vanus = int.Parse(Console.ReadLine());
                if (vanus >= 0 && vanus < 6)
                {
                    Console.WriteLine("Sulle kino on tasuta");

                }
                else if (vanus >= 6 && vanus <= 14)
                {
                    Console.WriteLine("Sul on vaja lastepilet osta");
                }
                else if (vanus >= 15 && vanus <= 65)
                {
                    Console.WriteLine("Sul on vaja täispilet osta");
                }
                else if (vanus > 65 && vanus <= 100)
                {
                    Console.WriteLine("Sul on vaja sooduspilet osta");
                }
                else
                {
                    Console.WriteLine("Andmete viga");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole!");
            }


            //1.osast kood
            Console.Write("\n\nSisesta esimene arv: ");//siin sama asi + panin \n\n, et oleks rea vahe
            int arv1 = int.Parse(Console.ReadLine());

            Console.Write("Sisesta esimene arv: ");//sama, lisasin mida peab sisestada
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);


            //2. osast
            //kysime kahe inimese nimed ja teatame, et nad on pinginaabrid
            Console.WriteLine("\n\n1.Sisesta oma nimi: ");
            string esimene_nimi = Console.ReadLine();
            Console.WriteLine("2.Sisesta oma nimi: ");
            string teine_nimi = Console.ReadLine();
            Console.WriteLine("Palju õnne " + esimene_nimi + " ja " + teine_nimi + ". Te olete pinginaabrid.");

            //2.osast
            //kysi ristkylikukujulise toa seinte pikkused ning arvuta poranda pindala.
            Console.Write("\n\nSiseta esimese seina pikkus: ");
            float esimene_sein = float.Parse(Console.ReadLine());

            Console.Write("Siseta teise seina pikkus: ");
            float teine_sein = float.Parse(Console.ReadLine());
            float pindala = esimene_sein * teine_sein;
            Console.WriteLine("Toa esimese seina pikkus on {0} ja teise seina pikkus on {1}. Põranda pindala võrdub {2}.", esimene_sein, teine_sein, pindala);
            //2.osast
            //kysige kas kasutaja soovib remondi teha, kui jah, siis kysi kui palju maksab ruutmeetr ja leia poranda vahetamise hind.
            Console.WriteLine("Kas soovite remondi teha?(Jah/Ei)");
            string remondi_soov = Console.ReadLine().ToLower();
            if (remondi_soov == "jah")
            {
                Console.WriteLine("Kui palju maksab ruutmeeter?");
                float rmhind = float.Parse(Console.ReadLine());
                float hind = pindala * rmhind;
                Console.WriteLine("Ruutmeetri hind on {0}, andtud pindala on {1}. Põranda vahetamise hind võrdub {2}.", rmhind, esimene_sein * teine_sein, hind);
                //2.osast
                //Leia 30% hinnasoodustusega hinna põhjal alghind
                //teen lihtsa variant, et oleks loogiline kysime kas  teil on kliendikaart ja siis teatame, et kaardiga on soodustus 30% ja uus hind on niisugune ja all täishind.
                Console.WriteLine("Kas Teil on kliendikaart?(Jah/Ei)");
                string kliendikaart = Console.ReadLine().ToLower();
                if (kliendikaart == "jah")
                {
                    int soodustus = 30;
                    float uus_hind = hind*((100f - soodustus)/100f);
                    Console.WriteLine("Kliendikaardiga soodustus on {0}%. \nSoodushind on {1}.\nTäishind on {2}.", soodustus, uus_hind, hind);
                }

            }
        }
    }
}
