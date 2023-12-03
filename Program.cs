using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.IO;

namespace EuroVizio
{
    internal class Program
    {
        static List<Versenyzo> versenyzok = new List<Versenyzo>();
        
        static void Main(string[] args)
        {
            string[] readVersenyzok = File.ReadAllLines("eurovizio.csv");
            for (int i = 0; i < readVersenyzok.Length; i++)
            {
                string[] tagok = readVersenyzok[i].Split(';');
                Versenyzo versenyzo = new Versenyzo(Convert.ToInt32(tagok[0]),
                tagok[1], tagok[2], tagok[3],Convert.ToInt32(tagok[4]), Convert.ToInt32(tagok[5]));
                versenyzok.Add(versenyzo);
                     
            }

            // 4. feladat:  Jelenítse meg, hogy mennyi versenyző adata van jelenleg eltárolva a listában!

            Console.WriteLine($"4. feladat: Versenyzők száma: {versenyzok.Count}");

            // 5. feladat:  Jelenjen meg az összes olyan dal címe neve, amely nem Magyarországról van!

            Console.WriteLine("5. feladat: Nem magyarországi versenyzők: ");

            List<string> nemMagyarok = new List<string>();

            foreach (var versenyzo in versenyzok)
            {
                if (versenyzo.Orszag != "Magyarország")
                {
                    nemMagyarok.Add(versenyzo.Cim);
                }
            }          

           foreach (var nemMagyar in nemMagyarok)
            {
                Console.WriteLine( nemMagyar);
            }

            /* 6.feladat: A versenyzőknek dicsőséglistát szeretnének a szervezők létrehozni, amelyhez a következő szabályok vannak:
                          ➢ A 2000 előtti versenyzőknél 150 pont vagy felettiek.
                          ➢ A 2000 vagy 2000 utániaknál 200 pont felettiek.
                          Ehhez készíts a Versenyzo osztályon belül TopLista néven logikai értékkel visszatérő
                          függvényt, amely meghatározza, hogy az adott versenyző toplistás - e az előbbi szabályokkal!  */
            // Megoldás a Versenyzo.cs-ben.


            /* 7. feladat: Olvasson be billentyűzetről egy ország nevét, majd jelenítse meg, hogy az adott ország átlagosan 
                           mennyi pontszámot ért el a dalaival!Ha az ország nincs a listában, akkor jelenjen meg, hogy
                           „Nem található ilyen nevű ország!”.  */

            Console.WriteLine("7.feladat: Kérem az országot: ");
            string keresettOrszag = Console.ReadLine();

            if(versenyzok.Any(x=>x.Orszag == keresettOrszag))
            {
                Console.WriteLine($" Az ország átlagos pontszáma: {versenyzok.Where(x=>x.Orszag == keresettOrszag).Average(x=>x.Pontszam):N0}");  
                 // N0 --> egész számra kerekít.
            }
            else
            {
                Console.WriteLine("Nem található ilyen nevű ország!");
            }                       
        }           
    }
}

/* 
                  4. feladat: Versenyzők száma: 1151
                  5. feladat: Nem magyarországi versenyzők:
                  Love Is
                  Ben Adam
                  Muzika i ti
                  This Time
                  Derech hamelech
                  O meu coraçao nao tem cor
                  Shake It
                  Singing This Song
                  Ne ver', ne boysia
                  ...

                 7.feladat: Kérem az országot: Magyarország
                 Az ország átlagos pontszáma: 61
                 Press any key to continue . . .

 */