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
                    float uus_hind = hind * ((100f - soodustus) / 100f);
                    Console.WriteLine("Kliendikaardiga soodustus on {0}%. \nSoodushind on {1}.\nTäishind on {2}.", soodustus, uus_hind, hind);
                }

            }
            //Küsi temperatuur ning teata, kas see on üle kaheksateistkümne kraadi (soovitav toasoojus talvel).
            Console.Write("\n\nSiseta toa temperatuur: ");
            float temperatuur = float.Parse(Console.ReadLine());
            if (temperatuur > 18 && temperatuur < 25)
            {
                Console.WriteLine("Temperatuur on üle kaheksateistkümne kraadi(soovitav toasoojus talvel)");

            }
            else
            {
                Console.WriteLine("Temperatuur on väljaspool soovituslikku vahemikku (18–25 °C).");
            }

            //Küsi inimese pikkus ning teata, kas ta on lühike, keskmine või pikk(piirid pane ise paika)

            Console.Write("\n\nSiseta oma pikkus: ");
            float pikkus = float.Parse(Console.ReadLine());
            if (pikkus > 50 && pikkus <= 150)
            {
                Console.WriteLine("Te olete lühike");

            }
            else if (pikkus > 150 && pikkus <= 175)
            {
                Console.WriteLine("Teie pikkus on keskmine");
            }
            else if (pikkus > 175 && pikkus <= 220)
            {
                Console.WriteLine("Te olete pikk");
            }
            else { Console.WriteLine("Pikkus ei saa olla väiksem kui 50 cm."); }

            //Küsi inimeselt pikkus ja sugu ning teata, kas ta on lühike, keskmine või pikk (mitu tingimusplokki võib olla üksteise sees).

            Console.WriteLine("Sisestage oma sugu(m/n): ");
            char sugu = char.Parse(Console.ReadLine().ToLower());
            if (sugu == 'n')
            {

                Console.Write("\n\nSiseta oma pikkus: ");
                pikkus = float.Parse(Console.ReadLine());
                if (pikkus > 50 && pikkus <= 160)
                {
                    Console.WriteLine("Proua! \nTe olete lühike");

                }
                else if (pikkus > 160 && pikkus <= 175)
                {
                    Console.WriteLine("Proua! \nTeie pikkus on keskmine");
                }
                else if (pikkus > 175 && pikkus <= 220)
                {
                    Console.WriteLine("Proua! \nTe olete pikk");
                }
                else { Console.WriteLine("Pikkus peab olema vahemikus 50 kuni 220 cm."); }
            }
            else if (sugu == 'm')
            {

                Console.Write("\n\nSiseta oma pikkus: ");
                pikkus = float.Parse(Console.ReadLine());
                if (pikkus > 50 && pikkus <= 170)
                {
                    Console.WriteLine("Härra! \nTe olete lühike");

                }
                else if (pikkus > 170 && pikkus <= 185)
                {
                    Console.WriteLine("Härra! \nTeie pikkus on keskmine");
                }
                else if (pikkus > 185 && pikkus <= 220)
                {
                    Console.WriteLine("Härra! \nTe olete pikk");
                }
                else { Console.WriteLine("Pikkus peab olema vahemikus 50 kuni 220 cm."); }
            }

            // Küsi inimeselt poes eraldi kas ta soovib osta piima, saia, leiba. Löö hinnad kokku ning teata, mis kõik ostetud kraam maksma läheb.
            Console.WriteLine("Tere tulemast poodi! \nKas soovite piima osta?(Jah/Ei)");
            string piima_soov = Console.ReadLine().ToLower();
            float kogu_summa = 0f;
            //piim
            if (piima_soov == "jah")
            {
                float piima_hind = 1.85f;
                kogu_summa +=  piima_hind;
                Console.WriteLine("Arvestame piima. \nPiima hind on {0}. \nKogusumma on {1}.", piima_hind, kogu_summa);
                
                

            }
            else 
            {
                Console.WriteLine("Edasi. \nPiima ei arvesta. \nKogusumma on {0}.",  kogu_summa);
               
            }

            //sai
            Console.WriteLine("Kas soovite saia osta?(Jah/Ei)");
            string saia_soov = Console.ReadLine().ToLower();
            if (saia_soov == "jah")
            {

                float saia_hind = 0.65f;
                kogu_summa += saia_hind;
                Console.WriteLine("Arvestame saia. \nSaia hind on {0}. \nKogusumma on {1}.", saia_hind, kogu_summa);
                
                

            }
            else
            {
                Console.WriteLine("Edasi. \nSaia ei arvesta. \nKogusumma on {0}.", kogu_summa);
                
            }

            //leib
            Console.WriteLine("Kas soovite leiba osta?(Jah/Ei)");
            string leiba_soov = Console.ReadLine().ToLower();
            if (leiba_soov == "jah")
            {
                float leiba_hind = 1.35f;
                kogu_summa += leiba_hind;
                Console.WriteLine("Arvestame leiba. \nLeiva hind on {0}. \nKogusumma on {1}.", leiba_hind, kogu_summa);

            }
            else
            {
                Console.WriteLine("Edasi. \nLeib ei arvesta. \nKogusumma on {0}.", kogu_summa);
            }
            Console.WriteLine("\nAitäh ostu eest! Kokku tuleb maksta: {0} €", kogu_summa);

        }
    } }
