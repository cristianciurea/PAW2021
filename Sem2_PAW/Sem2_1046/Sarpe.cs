using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1046
{
    class Sarpe: Animal
    {
        private int lungime;
        private bool esteVeninos;

        public Sarpe():base()
        {
            lungime = 0;
            esteVeninos = false;
        }

        public Sarpe(int v, string n, float g, int l, bool este):base(v, n, g)
        {
            lungime = l;
            esteVeninos = este;
        }

        public override string ToString()
        {
            return base.ToString() + " lungimea "+lungime+" si este veninos "+esteVeninos;
        }
    }
}
