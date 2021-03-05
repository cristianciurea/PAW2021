using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1049
{
    class Paun: Animal
    {
        private int inaltime;
        private bool arePenajFrumos;

        public Paun():base()
        {
            inaltime = 0;
            arePenajFrumos = true;
        }

        public Paun(int v, string n, float g, int i, bool are):base(v, n, g)
        {
            inaltime = i;
            arePenajFrumos = are;
        }

        public override string ToString()
        {
            return base.ToString()+" inaltimea "+inaltime+" si are penaj frumos "+arePenajFrumos;
        }
    }
}
