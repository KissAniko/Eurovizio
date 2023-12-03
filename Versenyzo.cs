using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuroVizio
{

    // verseny éve, az előadott dal országa, előadójának neve, címe, elért helyezés, és a pontszám
    internal class Versenyzo
    {
        int ev;
        string orszag;
        string nev;
        string cim;
        int helyezes;
        int pontszam;

        public Versenyzo(int ev, string orszag, string nev, string cim, int helyezes, int pontszam)
        {
            this.ev = ev;
            this.orszag = orszag;
            this.nev = nev;
            this.cim = cim;
            this.helyezes = helyezes;
            this.pontszam = pontszam;
        }

        // 6. feladat: TopLista néven logikai értékkel visszatérő függvény:
        public bool TopLista()
        {
            
            if (Ev < 2000 && Pontszam >= 150)
            {
                return true;
            }
            else if (Ev >= 2000 && Pontszam > 200)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Ev { get => ev; set => ev = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Helyezes { get => helyezes; set => helyezes = value; }
        public int Pontszam { get => pontszam; set => pontszam = value; }
    }
}
