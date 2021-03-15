using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_4
{
    [Serializable]
    abstract class Persoana
    {
        protected int cod;
        protected char sex;

        protected Persoana(int cod, char sex)
        {
            this.cod = cod;
            this.sex = sex;
        }

        public override string ToString()
        {
            return "Persoana cu codul " + cod + " are sexul " + sex;
        }
    }
}
