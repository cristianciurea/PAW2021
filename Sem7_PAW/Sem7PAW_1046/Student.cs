using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem7PAW_1046
{
    class Student
    {
        private int cod;
        private string nume;
        private int nota;

        public Student(int c, string n, int nt)
        {
            cod = c;
            nume = n;
            nota = nt;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Nume { get => nume; set => nume = value; }
        public int Nota { get => nota; set => nota = value; }

        public override string ToString()
        {
            return "Studentul " + nume + " are codul " + cod + " si nota " + nota;
        }
    }
}
