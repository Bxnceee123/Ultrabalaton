using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ultrabalaton
{
    internal class Versenyző
    {
        public string Nev { get; set; }
        public int Rajtszam { get; set; }
        public string Kategoria { get; set; }
        public string Versenyido { get; set; }
        public int TavSzazalek { get; set; }

        public Versenyző(string sor)
        {
            string[] s = sor.Split(';');

            Nev = s[0];
            Rajtszam = int.Parse(s[1]);
            Kategoria = s[2];
            Versenyido = s[3];
            TavSzazalek = int.Parse(s[4]);
        }

    }
}
