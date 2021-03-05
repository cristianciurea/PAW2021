using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1048
{
    class Elefant: Animal
    {
        private float inaltime;
        private char sex;
        private string taraOrigine;

        public Elefant(): base()
        {
            inaltime = 0;
            sex = 'F';
            taraOrigine = "India";
        }

        public Elefant(int v, string n, float g, float h, char s, string t):base(v, n, g)
        {
            inaltime = h;
            sex = s;
            taraOrigine = t;
        }

        public float Inaltime { get => inaltime; set => inaltime = value; }
        public char Sex { get => sex; set => sex = value; }
        public string TaraOrigine { get => taraOrigine; set => taraOrigine = value; }

        public override string ToString()
        {
            return base.ToString()+" inaltimea "+inaltime+" sexul "+sex+" si tara de origine "+taraOrigine;
        }
    }
}
