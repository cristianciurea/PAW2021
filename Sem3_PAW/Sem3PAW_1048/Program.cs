using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1048
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            int[] vect1 = { 7, 8, 9 };

            Student s2 = new Student(100, 'M', 21, "Gigel",  vect1);
            s2 = s2 + 9;
            s2 += 5;
            s2++;
            Console.WriteLine("Media notelor lui s2: " + (float)s2);
            Console.WriteLine(s2);

            Student s3 = (Student)s2.Clone();
            s3++;
            s3[6] = 5;
            Console.WriteLine("A 4-a nota a lui s3: " + s3[3]);
            Console.WriteLine(s3);
            Console.WriteLine("Media notelor lui s3: " + s3.calculeazaMedie());

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
            foreach (Student s in listaStud)
                Console.WriteLine(s);

            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
