using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2_1046
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal(10, "Zoro", 150);
            Animal a3 = (Animal)a2.Clone();
            a3.Nume = "Grivei";
            a3.Greutate = 150;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);

            Pantera p1 = new Pantera(15, "Pantera Roz", 50, "roz", true);
            Sarpe s1 = new Sarpe(20, "Python", 40, 5, false);

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(p1);
            z1.ListaAnimale.Add(s1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire = "Berlin";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";
            z1.ListaAnimale.Sort();
            z2.ListaAnimale.Sort();
            Console.WriteLine(z1);
            Console.WriteLine(z2);
            Console.WriteLine("-----------------------");
            Console.WriteLine(z2[3]);

            Console.WriteLine("-----------------------");
            a2 += 10;
            a3 = a3 + 12;
            a1 = 15 + a1;
            Console.WriteLine(a1);
            Console.WriteLine(a2);
            Console.WriteLine(a3);
        }
    }
}
