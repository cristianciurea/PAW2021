using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1049
{
    class Castor: Animal
    {
        private string culoare;
        private int lungimeDinti;
        private char gen;

        public Castor(): base()
        {
            culoare = "maro";
            lungimeDinti = 0;
            gen = 'F';
        }

        public Castor(int v, string n, float g, string c, int lg, char gn):base(v, n, g)
        {
            culoare = c;
            lungimeDinti = lg;
            gen = gn;
        }

        public string Culoare { get => culoare; set => culoare = value; }
        public int LungimeDinti { get => lungimeDinti; set => lungimeDinti = value; }
        public char Gen { get => gen; set => gen = value; }

        public override string ToString()
        {
            return base.ToString() + " culoare "+culoare+" lungime dinti "+lungimeDinti+
                " si genul "+gen;
        }
    }
}
