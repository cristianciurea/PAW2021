using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem4PAW_1046
{
    [Serializable]
    public class Student : Persoana, ICloneable, IComparable, IMedia
    {
        private int varsta;
        private string nume;
        private int[] note;

        public Student():base()
        {
            varsta = 0;
            nume = "Anonim";
            note = null;
        }

        public Student(int c, char s, int v, string n, int[] nt): base(c, s)
        {
            varsta = v;
            nume = n;
            /*note = new int[nt.Length];
            for (int i = 0; i < nt.Length; i++)
                note[i] = nt[i];*/
            note = (int[])nt.Clone();
        }

        public override string ToString()
        {
            string rezultat = base.ToString() +" varsta "+varsta+" numele "+nume;
            if (note != null)
            {
                rezultat += " si are urmatoarele note ";
                for (int i = 0; i < note.Length; i++)
                    rezultat += note[i] + " ";
            }
            else
                rezultat += " si nu are note";
            return rezultat;
        }

        public float calculeazaMedie()
        {
            return (float)this;
        }

        public object Clone()
        {
            Student clona =(Student) this.MemberwiseClone();
            int[] noteNoi = (int[])note.Clone();
            clona.note = noteNoi;
            return clona;
        }

        public int CompareTo(object obj)
        {
            Student s = (Student)obj;
            if ((float)this > (float)s)
                return -1;
            else
                if ((float)this < (float)s)
                return 1;
            else
                return string.Compare(this.nume, s.nume);
        }

        public override void spuneAnNastere()
        {
            Console.WriteLine("Anul nasterii este: {0}", System.DateTime.Now.Year - varsta);
        }

        public static Student operator+ (Student s, int notaNoua)
        {
            int[] noteNoi = new int[s.note.Length + 1];
            for (int i = 0; i < s.note.Length; i++)
                noteNoi[i] = s.note[i];
            noteNoi[noteNoi.Length - 1] = notaNoua;
            s.note = noteNoi;
            return s;
        }

        public static Student operator++(Student s)
        {
            return s + 1;
        }

        public static explicit operator float(Student s)
        {
            if (s.note != null)
            {
                int suma = 0;
                for (int i = 0; i < s.note.Length; i++)
                    suma += s.note[i];
                return (float)suma / s.note.Length;
            }
            else
                return 0;
        }

        public int Varsta
        {
            get { return varsta; }
            set { if (value>0) varsta = value; }
        }

        public int this[int index]
        {
            get
            {
                if (note != null && index >= 0 && index < note.Length)
                    return note[index];
                else
                    return 0;
            }
            set
            {
                if (value > 0 && value <= 10 && index >= 0 && index < note.Length)
                    note[index] = value;
            }
        }
    }
}
