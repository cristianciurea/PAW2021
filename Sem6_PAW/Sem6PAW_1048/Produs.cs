using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem6PAW_1048
{
    public class Produs
    {
        public string denumire;
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
            return "Produsul " + denumire + " cu pretul " + pret +
                " si cantitatea " + cantitate+" are valoarea "+(pret*cantitate);
        }
    }
}
