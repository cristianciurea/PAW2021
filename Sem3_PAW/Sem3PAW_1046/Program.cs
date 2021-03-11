using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem3PAW_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(123, 'M', 21, "Gigel", new int[3] { 8, 9, 10 });
            Student s3 = (Student)s2.Clone();
            Console.WriteLine(s1);
            s2 = s2 + 10;
            s2 += 5;
            s2++;
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            s3.spuneAnNastere();
            Console.WriteLine("A 5-a nota a lui s2: " + s2[4]);
            s2[5] = 5;
            Console.WriteLine(s2);

            Console.WriteLine("---------------------------------------");

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
