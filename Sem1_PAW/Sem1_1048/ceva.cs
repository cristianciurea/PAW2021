﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem1_1048
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Cum te cheama?");
            string nume = Console.ReadLine();
            string prenume = Console.ReadLine();
            Console.Write("Numele meu este {0} si prenumele {1}", nume, prenume);*/

            int[] v1 = { 1, 2, 3, 4 };
            for (int i = 0; i < v1.Length; i++)
                Console.WriteLine(v1[i]);
            int[] v2 = new int[4] { 1, 2, 3, 4 };
            //shallow copy
            int[] v3 = v2;
            v2[1] = 10;
            for (int i = 0; i < v3.Length; i++)
                Console.WriteLine(v3[i]);
            //deep copy - var 1
            int[] v4 = new int[v2.Length];
            for (int i = 0; i < v2.Length; i++)
                v4[i] = v2[i];
            v2[1] = 20;
            for (int i = 0; i < v4.Length; i++)
                Console.WriteLine(v4[i]);
            //deep copy - var 2
            int[] v5 = (int[])v2.Clone();
            v2[1] = 30;
            for (int i = 0; i < v5.Length; i++)
                Console.WriteLine(v5[i]);

            int[,] mb1 = new int[2, 3] { { 10, 20, 30 }, { 40, 50, 60 } };
            for (int i = 0; i < mb1.GetLength(0); i++) 
            {
                for (int j = 0; j < mb1.GetLength(1); j++)
                    Console.Write("{0} ", mb1[i, j]);
                Console.WriteLine();
            }

            int[][] mb2 = new int[2][];
            mb2[0] = new int[3] { 10, 20, 30 };
            mb2[1] = new int[4] { 40, 50, 60, 70 };
            for (int i = 0; i < mb2.Length; i++)
            {
                for (int j = 0; j < mb2[i].Length; j++)
                    Console.Write("{0} ", mb2[i][j]);
                Console.WriteLine();
            }

            Student s1 = new Student();
            Student s2 = new Student(123, "Gigel", 22, 9.5f);
            Student s3 = new Student(s2);

            s3.Nume = "Dorel";
            Console.WriteLine(s3.Nume);

            s1.afisare();
            s2.afisare();
            s3.afisare();

            Student[] vectStud = new Student[3] { s1, s2, s3 };
            for (int i = 0; i < vectStud.Length; i++)
                Console.WriteLine(vectStud[i]);
            for (int i = 0; i < vectStud.Length; i++)
                vectStud[i].afisare();

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Remove(s2);
            foreach (Student s in listaStud)
                Console.WriteLine(s);
            for (int i = 0; i < listaStud.Count; i++)
                Console.WriteLine(listaStud[i]);
        }
    }
}
