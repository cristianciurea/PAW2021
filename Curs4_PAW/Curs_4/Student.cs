using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_4
{
    [Serializable]
    class Student: Persoana
    {
        private int varsta;
        private string nume;
        private float medie;

        public Student(int cod, char sex, int varsta, string nume, float medie): base(cod, sex)
        {
            this.varsta = varsta;
            this.nume = nume;
            this.medie = medie;
        }

        public override string ToString()
        {
            return base.ToString() + " varsta "+varsta+" numele "+nume+" si media "+medie;
        }
    }
}
