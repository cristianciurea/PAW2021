using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs_6
{
    class Student
    {
        private string nume;
        private string cnp;
        private string sex;
        private int nota;

        public Student(string n, string c, string s, int nt)
        {
            nume = n;
            cnp = c;
            sex = s;
            nota = nt;
        }

        public override string ToString()
        {
            return "Studentul " + nume + " cu cnp-ul " + cnp + " si sexul " + sex + " are nota " + nota;
        }
    }
}
