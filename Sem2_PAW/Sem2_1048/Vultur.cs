using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1048
{
    class Vultur: Animal
    {
        private int lungimeAripi;
        private int viteza;
        private bool esteAdult;

        public Vultur():base()
        {
            lungimeAripi = 0;
            viteza = 0;
            esteAdult = true;
        }

        public Vultur(int v, string n, float g, int lg, int vit, bool este):base(v, n, g)
        {
            lungimeAripi = lg;
            viteza = vit;
            esteAdult = este;
        }

        public override string ToString()
        {
            return base.ToString() + " lungime aripi "+lungimeAripi+" viteza "+viteza+
                " si este adult "+esteAdult;
        }
    }
}
