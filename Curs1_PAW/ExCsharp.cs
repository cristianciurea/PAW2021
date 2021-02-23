using System;
using System.Collections.Generic;
using System.Text;

namespace ExCsharp
{
    class Student: ICloneable
    {
        private int varsta;
        private string nume;
        private float medie;

        public Student()
        {
            varsta = 0;
            nume = "Gigel";
            medie = 0.0f;
        }

        public Student(int v, string n, float m)
        {
            varsta = v;
            nume = n;
            medie = m;
        }

        public Student(Student s)
        {
            varsta = s.varsta;
            nume = s.nume;
            medie = s.medie;
        }

        public int getVarsta()
        {
            return this.varsta;
        }
        public void setVarsta(int v)
        {
            this.varsta = v;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public float getMedie
        {
            get { return medie; }
        }
        public float setMedie
        {
            set { this.medie = value; }
        }

        public void afisare()
        {
            //Console.WriteLine("Varsta: {0}", varsta);
            //Console.WriteLine("Nume: {0}", nume);
            //Console.WriteLine("Media: {0}", medie);
            Console.WriteLine("Varsta: {0}, Nume: {1}, Media: {2}", varsta, nume, medie);
        }

        public Student Clone()
        {
            Student s = (Student)((ICloneable)this).Clone();
            return s;
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(29, "Ionescu", 9.85f);
            Student s3 = new Student(s2);
            Student s4 = s2; //s4(s2) NU MERGE
            Student s5 = s2.Clone();

            s1.afisare();
            s2.afisare();
            s3.afisare();
            s4.afisare();
            s5.afisare();

            s3.setVarsta(33);
            Console.WriteLine(s3.getVarsta());
            s3.Nume = "Mirel";
            Console.WriteLine(s3.Nume);
            s3.setMedie = 9.99f;
            Console.WriteLine(s3.getMedie);
        }
    }
}
