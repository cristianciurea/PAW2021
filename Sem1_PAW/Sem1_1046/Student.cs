using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1_1046
{
    class Student
    {
        int cod;
        private string nume;
        public int varsta;
        protected float medie;

        public Student()
        {
            this.cod = 0;
            this.nume = "Anonim";
            this.varsta = 0;
            this.medie = 0.0f;
        }

        public Student(int c, string n, int v, float m)
        {
            this.cod = c;
            this.nume = n;
            this.varsta = v;
            this.medie = m;
        }

        public Student(Student s)
        {
            this.cod = s.cod;
            this.nume = s.nume;
            this.varsta = s.varsta;
            this.medie = s.medie;
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public void afisare()
        {
            Console.WriteLine("Studentul {0} are codul {1}, varsta {2} si media {3}", nume, cod, varsta, medie);
        }

        public override string ToString()
        {
            return "Studentul "+nume+" are codul "+cod+", varsta "+varsta+" si media "+medie;
        }
    }
}
