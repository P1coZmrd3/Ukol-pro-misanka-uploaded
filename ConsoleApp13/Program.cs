// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kokot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // zjisti mesic a ulozi do stringu (tohle jsem stealnul od tebe :D)


            DateTime cas = DateTime.Now;
            int CisloMesice = cas.Month;
            string[] poleMesicu = { "Leden", "Unor", "Brezen", "Duben", "Kveten", "Cerven", "Cervenec", "Srpen", "Zari", "Rijen", "Listopad", "Prosinec" };

            Console.WriteLine($"Teď je {poleMesicu[CisloMesice - 1]}, další měsíc je {poleMesicu[CisloMesice]}, minuly mesic {poleMesicu[CisloMesice - 2]}");
            Console.WriteLine("-----");

            //tohle se vypise do konzole a uzivatel zada cislo 1-12


            Console.WriteLine("Napiš číslo měsíce 1. - 12.");

            int Mesic = Convert.ToInt32(Console.ReadLine());
            int minusake = Mesic - 1;
            int picoammalyperoe = Mesic + 1;

            //jednoduse se podle cisla mesice, ktery uzivatel vybere vypise soucasny mesic, potom ten co bude a co byl 


            if (Mesic >= 2 && Mesic <= 11)
            {
                Console.WriteLine($"Teď je {poleMesicu[Mesic - 1]}, další měsíc je {poleMesicu[picoammalyperoe - 1]}, minuly mesic {poleMesicu[minusake - 1]}");
                Console.WriteLine("-----");
            }
            else if (Mesic == 1)
            {
                Console.WriteLine($"Teď je leden, další měsíc je unor minuly mesic prosienc");
                Console.WriteLine("-----");
            }
            else if (Mesic == 12)
            {
                Console.WriteLine($"Teď je prosinec, další měsíc je ledn, minuly mesic listopad");
                Console.WriteLine("-----");
            }
            // tady se na konci program zepta, jestli ches vypsat vsechny mesice co jsou, vyberes ano/ne a podle toho dostanes odpoved


            Console.WriteLine("Chces vypsat vsechny mesice pico? (JO/NE)");
            string odpovedPico = Console.ReadLine();
            if (odpovedPico == "JO")
            {
                foreach (string pole in poleMesicu)
                {
                    Console.WriteLine(pole);
                    
                }
            }
            else if (odpovedPico == "NE")
            {
                Console.WriteLine("jdi do pici");
                Console.ReadLine();
            }
        }

    }
}

