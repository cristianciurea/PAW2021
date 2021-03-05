using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1046
{
    class Pantera: Animal
    {
        private string culoare;
        private bool esteHranita;

        public Pantera(): base()
        {
            culoare = "roz";
            esteHranita = true;
        }

        public Pantera(int v, string n, float g, string c, bool este):base(v, n, g)
        {
            culoare = c;
            esteHranita = este;
        }

        public string Culoare { get => culoare; set => culoare = value; }
        public bool EsteHranita { get => esteHranita; set => esteHranita = value; }

        public override string ToString()
        {
            return base.ToString() + " culoarea "+culoare+" si este hranita "+esteHranita;
        }
    }
}
