using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem6PAW_1046
{
    class Produs
    {
        private string denumire;
        private float pret;
        private float cantitate;

        public Produs(string d, float p, float c)
        {
            denumire = d;
            pret = p;
            cantitate = c;
        }

        public override string ToString()
        {
            return "Produsul " + denumire + " are pretul " + pret +
                " si cantitatea " + cantitate;
        }
    }
}
