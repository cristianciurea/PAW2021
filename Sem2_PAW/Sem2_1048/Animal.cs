using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1048
{
    class Animal: ICloneable, IComparable
    {
        private int varsta;
        private string nume;
        private float greutate;

        public Animal()
        {
            varsta = 0;
            this.nume = "Anonim";
            this.greutate = 0.0f;
        }

        public Animal(int v, string n, float g)
        {
            varsta = v;
            nume = n;
            greutate = g;
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value > 0) varsta = value; }
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public float Greutate
        {
            get { return greutate; }
            set { if (value > 0) greutate = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            Animal a = (Animal)obj;
            if (this.greutate < a.greutate)
                return -1;
            else
                if (this.greutate > a.greutate)
                return 1;
            else
                return string.Compare(this.nume, a.nume);
        }

        public override string ToString()
        {
            return "Animalul " + nume + " are varsta " + varsta + " si greutatea " + greutate;
        }

        public static Animal operator +(int x, Animal a)
        {
            return a + x;
        }

        public static Animal operator +(Animal a, int x)
        {
            a.varsta += x;
            return a;
        }
    }
}
