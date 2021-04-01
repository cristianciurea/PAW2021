using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem5PAW_1046
{
    public class Credit
    {
        private int suma;
        private int perioada;
        private float dobanda;
        private float rata;

        public Credit(int s, int p, float d, float r)
        {
            suma = s;
            perioada = p;
            dobanda = d;
            rata = r;
        }

        public override string ToString()
        {
            return "Creditul in suma de " + suma + " pe perioada " + perioada +
                " cu dobanda " + dobanda + " are rata " + rata;
        }
    }
}
